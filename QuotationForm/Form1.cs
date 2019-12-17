using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuotationApp__Clean_Version_;

namespace QuotationForm
{
    public partial class Form1 : Form
    {
        private enum _materialType {Rods, HollowRods, Flats};
        private readonly List<_materialType> _materialTypes = new List<_materialType>{_materialType.Rods, _materialType.HollowRods, _materialType.Flats };

        private SQLQuery sQLQuery;
        List<RawMaterial> rawMaterials;



        protected Rod currentRod = new Rod("Blank", 1, 1, 1, 1, 1);
        protected Flat currentFlat = new Flat("BlankFlat", 1, 1, 1, 1, 1, 1);


        public Form1()
        {
            InitializeComponent();
        }

        private void Print(string text)
        {
            Console.WriteLine(text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RawMaterial shape = new Rod("Rod1", 1.23, 2, 3, 4, 6);
            shape.CalculateCost();

            Console.WriteLine("hey" + shape.TotalCost.ToString());


            sQLQuery = new SQLQuery();
            ComboMaterialType.DataSource = _materialTypes;
        }

        private void ComboMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayMaterials();
        }

        private void DisplayMaterials()
        {
            switch (ComboMaterialType.SelectedIndex)
            {
                case -1:
                    Print("New");
                    break;
                case 0:
                    Print("Rods");
                    sQLQuery.GetRods();
                    rawMaterials = new List<RawMaterial>(sQLQuery.RodList);

                    label11.Visible = false;
                    TxtThickness.Visible = false;
                    break;
                case 1:
                    Print("Hollows");
                    label11.Visible = true;
                    label11.Text = "Inner Diameter";
                    label11.Location = new Point(60,222);
                    label5.Text = "Outer Diameter";
                    label5.Location = new Point(105, 174);
                    TxtThickness.Visible = true;
                    break;
                case 2:
                    Print("Flats");
                    label11.Visible = true;
                    label11.Text = "Height";
                    label11.Location = new Point(78, 222);
                    label5.Text = "Width";
                    label5.Location = new Point(126, 174);
                    TxtThickness.Visible = true;

                    sQLQuery.GetFlats();
                    rawMaterials = new List<RawMaterial>(sQLQuery.FlatList);

                    break;
                default:
                    Print("default");
                    break;
            }

            ComboMaterialName.DataSource = null;
            ComboMaterialName.DisplayMember = "Name";
            ComboMaterialName.ValueMember = null;
            ComboMaterialName.DataSource = rawMaterials;
            ComboMaterialName.SelectedItem = ComboMaterialName.Items[ComboMaterialName.Items.Count - 1];
        }

        private void ComboMaterialName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboMaterialName.SelectedIndex != -1)
            {
                TxtDensity.ReadOnly = true;

                if (ComboMaterialName.SelectedIndex == 0)
                {
                    TxtDensity.ReadOnly = false;
                    TxtRawName.Visible = true;
                    BtnSaveRawMaterial.Visible = true;
                    Print("selected New*************************");
                    currentRod = new Rod("Blank", 1, 1, 1, 1, 1);
                }
                else
                {
                    currentRod = (Rod)ComboMaterialName.SelectedItem;
                    TxtDensity.ReadOnly = true;
                    TxtRawName.Visible = false;
                    BtnSaveRawMaterial.Visible = false;
                }

                //var currentMaterial = (Rod)ComboMaterialName.SelectedItem;

                TxtLength.Text = currentRod.Length.ToString();
                TxtDiameter.Text = currentRod.Diameter.ToString();
                TxtDensity.Text = currentRod.Density.ToString();
                TxtPricePerKilo.Text = string.Format("{0:C2}", currentRod.CostPerKg);
                TxtUnitPrice.Text = string.Format("{0:C2}", currentRod.UnitCost);
                TxtQty.Text = currentRod.Qty.ToString();
                TxtTotalPrice.Text = string.Format("{0:C2}", currentRod.TotalCost);
            }
        }

        private void BtnSaveRawMaterial_Click(object sender, EventArgs e)
        {
            //Rod rod = new Rod("SS316 ROUND", 8000, 12, 1, 0.025, 0.225);
            //if ()
            //var currentMaterial = (RawMaterial)ComboMaterialName.SelectedItem;

            if (ComboMaterialName.SelectedIndex >= 0)
            {
                switch (ComboMaterialType.SelectedIndex)
                {
                    case -1:
                        Print("New");
                        break;
                    case 0:
                        Print("Rods222");
                        
                        //currentRod = new Rod()

                        var sb = new StringBuilder();
                        UpdateCurrentRod();
                        sQLQuery.AddRod(currentRod);
                        sb.AppendLine(currentRod.Name);
                        sb.AppendLine(currentRod.Density.ToString());
                        sb.AppendLine(currentRod.CostPerKg.ToString());
                        sb.AppendLine(currentRod.Qty.ToString());
                        sb.AppendLine(currentRod.Diameter.ToString());
                        sb.AppendLine(currentRod.Length.ToString());


                        //textBox1.Text = sb.ToString();
                        break;
                    case 1:
                        Print("Hollows");
                        break;
                    case 2:
                        Print("Flats");
                        break;
                    default:
                        Print("default");
                        break;
                }
            }
            
            DisplayMaterials();
        }

        private void BtnDeleteRawMaterial_Click(object sender, EventArgs e)
        {
            var currentMaterial = (RawMaterial)ComboMaterialName.SelectedItem;
            sQLQuery.DeleteRod(currentMaterial.Id);
            DisplayMaterials();
        }

        private void TxtLength_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(TxtLength.Text, out double length);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                //currentRod = ((Rod)ComboMaterialName.SelectedItem);
                currentRod.Length = length;
                ShowTotalPriceRaw();
            }

        }

        private void TxtLength_LostFocus(object sender, EventArgs e)
        {
            TxtLength.Text = string.Format("{0:N6}", currentRod.Length);
        }

        private void TxtDiameter_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(TxtDiameter.Text, out double diameter);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                //currentRod = ((Rod)ComboMaterialName.SelectedItem);
                currentRod.Diameter = diameter;
                ShowTotalPriceRaw();
            }
        }

        private void TxtDiameter_LostFocus(object sender, EventArgs e)
        {
            TxtDiameter.Text = string.Format("{0:N6}", currentRod.Diameter);
        }

        private void TxtThickness_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtThickness_LostFocus(object sender, EventArgs e)
        {
            TxtDiameter.Text = string.Format("{0:N6}", currentRod.Diameter);
        }

        private void TxtPricePerKilo_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = decimal.TryParse(TxtPricePerKilo.Text, System.Globalization.NumberStyles.Any, CultureInfo.CreateSpecificCulture("en-AU"), out decimal pricePerKilo);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                //currentRod = ((Rod)ComboMaterialName.SelectedItem);
                currentRod.CostPerKg = (double)pricePerKilo;
                ShowTotalPriceRaw();
            }
        }

        private void TxtPricePerKilo_LostFocus(object sender, EventArgs e)
        {
            TxtPricePerKilo.Text = string.Format("{0:C2}", currentRod.CostPerKg);
        }

        private void TxtQuantityRaw_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(TxtQty.Text, out double qty);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                //currentRod = ((Rod)ComboMaterialName.SelectedItem);
                currentRod.Qty = qty;
                ShowTotalPriceRaw();
            }
        }

        private void TxtQuantityRaw_LostFocus(object sender, EventArgs e)
        {
            TxtQty.Text = string.Format("{0:N}", currentRod.Qty);
        }

        private void TxtDensity_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(TxtDensity.Text, out double density);

            if (TxtDensity.TextLength > 0 && isNumeric)
            {
                //currentRod = ((Rod)ComboMaterialName.SelectedItem);
                currentRod.Density = density;
                //UpdateCurrentRod();
                ShowTotalPriceRaw();
            }
        }

        private void TxtDensity_LostFocus(object sender, EventArgs e)
        {
            //TxtDensity.Text = string.Format("{0:N}", ((Rod)ComboMaterialName.SelectedItem).Density);
            TxtDensity.Text = string.Format("{0:N}", currentRod.Density);
        }

        private void UpdateCurrentRod()
        {
            try
            {
                currentRod.Name = TxtRawName.Text;
                currentRod.Density = double.Parse(TxtDensity.Text);
                currentRod.CostPerKg = double.Parse(TxtPricePerKilo.Text, NumberStyles.Currency);
                currentRod.Qty = double.Parse(TxtQty.Text);
                currentRod.Diameter = double.Parse(TxtDiameter.Text);
                currentRod.Length = double.Parse(TxtLength.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message);
            }
        }

        private void ShowTotalPriceRaw()
        {
            currentRod.CalculateCost();
            TxtUnitPrice.Text = string.Format("{0:C2}", currentRod.UnitCost);
            TxtTotalPrice.Text = string.Format("{0:C2}", currentRod.TotalCost);
        }

    }
}
