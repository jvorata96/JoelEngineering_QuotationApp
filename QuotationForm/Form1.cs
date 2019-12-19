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
        protected HollowRod currentHollowRod = new HollowRod("BlankHollow", 1, 1, 1, 1, 1, 1);


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

                    sQLQuery.GetHollowRods();
                    rawMaterials = new List<RawMaterial>(sQLQuery.HollowRodList);

                    break;
                case 2:
                    Print("Flats");
                    label11.Visible = true;
                    label11.Text = "Thickness";
                    label11.Location = new Point(70, 222);
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
                    currentFlat = new Flat("Blank", 1, 1, 1, 1, 1, 1);
                }
                else
                {
                    switch (ComboMaterialType.SelectedIndex)
                    {
                        case 0:
                            currentRod = (Rod)ComboMaterialName.SelectedItem;
                            TxtLength.Text = currentRod.Length.ToString();
                            TxtDiameter.Text = currentRod.Diameter.ToString();
                            TxtDensity.Text = currentRod.Density.ToString();
                            TxtPricePerKilo.Text = string.Format("{0:C2}", currentRod.CostPerKg);
                            TxtUnitPrice.Text = string.Format("{0:C2}", currentRod.UnitCost);
                            TxtQty.Text = currentRod.Qty.ToString();
                            TxtTotalPrice.Text = string.Format("{0:C2}", currentRod.TotalCost);
                            break;
                        case 1:
                            currentHollowRod = (HollowRod)ComboMaterialName.SelectedItem;
                            TxtLength.Text = currentHollowRod.Length.ToString();
                            TxtDiameter.Text = currentHollowRod.DiameterOut.ToString();
                            TxtThickness.Text = currentHollowRod.DiameterIn.ToString();
                            TxtDensity.Text = currentHollowRod.Density.ToString();
                            TxtPricePerKilo.Text = string.Format("{0:C2}", currentHollowRod.CostPerKg);
                            TxtUnitPrice.Text = string.Format("{0:C2}", currentHollowRod.UnitCost);
                            TxtQty.Text = currentHollowRod.Qty.ToString();
                            TxtTotalPrice.Text = string.Format("{0:C2}", currentHollowRod.TotalCost);
                            break;
                        case 2:
                            currentFlat = (Flat)ComboMaterialName.SelectedItem;
                            TxtLength.Text = currentFlat.Length.ToString();
                            TxtDiameter.Text = currentFlat.Width.ToString();
                            TxtThickness.Text = currentFlat.Thickness.ToString();
                            TxtDensity.Text = currentFlat.Density.ToString();
                            TxtPricePerKilo.Text = string.Format("{0:C2}", currentFlat.CostPerKg);
                            TxtUnitPrice.Text = string.Format("{0:C2}", currentFlat.UnitCost);
                            TxtQty.Text = currentFlat.Qty.ToString();
                            TxtTotalPrice.Text = string.Format("{0:C2}", currentFlat.TotalCost);
                            break;
                        default:
                            break;
                    }
                    
                    TxtDensity.ReadOnly = true;
                    TxtRawName.Visible = false;
                    BtnSaveRawMaterial.Visible = false;
                }

                //var currentMaterial = (Rod)ComboMaterialName.SelectedItem;

                
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
                        sb = new StringBuilder();
                        UpdateCurrentHollowRod();
                        sQLQuery.AddHollowRod(currentHollowRod);
                        sb.AppendLine(currentHollowRod.Name);
                        sb.AppendLine(currentHollowRod.Density.ToString());
                        sb.AppendLine(currentHollowRod.CostPerKg.ToString());
                        sb.AppendLine(currentHollowRod.Qty.ToString());
                        sb.AppendLine(currentHollowRod.DiameterOut.ToString());
                        sb.AppendLine(currentHollowRod.DiameterIn.ToString());
                        sb.AppendLine(currentHollowRod.Length.ToString());
                        Print(sb.ToString());
                        break;
                    case 2:
                        Print("Flats333");

                        //currentRod = new Rod()

                        sb = new StringBuilder();
                        UpdateCurrentFlat();
                        sQLQuery.AddFlat(currentFlat);
                        sb.AppendLine(currentFlat.Name);
                        sb.AppendLine(currentFlat.Density.ToString());
                        sb.AppendLine(currentFlat.CostPerKg.ToString());
                        sb.AppendLine(currentFlat.Qty.ToString());
                        sb.AppendLine(currentFlat.Length.ToString());
                        sb.AppendLine(currentFlat.Thickness.ToString());
                        sb.AppendLine(currentFlat.Width.ToString());
                        Print(sb.ToString());
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
            switch(ComboMaterialType.SelectedIndex)
            {
                case 0:
                    sQLQuery.DeleteRod(currentMaterial.Id);
                    break;
                case 1:
                    //sQLQuery.DeleteRod(currentMaterial.Id);
                    sQLQuery.DeleteHollowRod(currentMaterial.Id);

                    break;
                case 2:
                    sQLQuery.DeleteFlat(currentMaterial.Id);

                    break;
                default:
                    break;
            }
            
            DisplayMaterials();
        }

        private void TxtLength_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(TxtLength.Text, out double length);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                //currentRod = ((Rod)ComboMaterialName.SelectedItem);
                currentRod.Length = length;
                currentFlat.Length = length;
                currentHollowRod.Length = length;
                ShowTotalPriceRaw();
            }

        }

        private void TxtLength_LostFocus(object sender, EventArgs e)
        {
            switch(ComboMaterialType.SelectedIndex)
            {
                case 0:
                    TxtLength.Text = string.Format("{0:N6}", currentRod.Length);
                    break;
                case 1:
                    TxtLength.Text = string.Format("{0:N6}", currentHollowRod.Length);
                    break;
                case 2:
                    TxtLength.Text = string.Format("{0:N6}", currentFlat.Length);
                    break;
            }
        }

        private void TxtDiameter_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(TxtDiameter.Text, out double diameter);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                //currentRod = ((Rod)ComboMaterialName.SelectedItem);
                currentRod.Diameter = diameter;
                currentFlat.Width = diameter;
                currentHollowRod.DiameterOut = diameter;
                ShowTotalPriceRaw();
            }
        }

        private void TxtDiameter_LostFocus(object sender, EventArgs e)
        {     
            switch (ComboMaterialType.SelectedIndex)
            {
                case 0:
                    TxtDiameter.Text = string.Format("{0:N6}", currentRod.Diameter);
                    break;
                case 1:
                    TxtDiameter.Text = string.Format("{0:N6}", currentHollowRod.DiameterOut);
                    break;
                case 2:
                    TxtDiameter.Text = string.Format("{0:N6}", currentFlat.Width);
                    break;
            }
        }

        private void TxtThickness_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(TxtThickness.Text, out double thickness);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                //currentRod = ((Rod)ComboMaterialName.SelectedItem);
                //currentRod.Diameter = thickness;
                currentFlat.Thickness = thickness;
                currentHollowRod.DiameterIn = thickness;
                ShowTotalPriceRaw();
            }
        }

        private void TxtThickness_LostFocus(object sender, EventArgs e)
        {
            switch (ComboMaterialType.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    TxtThickness.Text = string.Format("{0:N6}", currentHollowRod.DiameterIn);
                    break;
                case 2:
                    TxtThickness.Text = string.Format("{0:N6}", currentFlat.Thickness);
                    break;
            }
        }

        private void TxtPricePerKilo_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = decimal.TryParse(TxtPricePerKilo.Text, System.Globalization.NumberStyles.Any, CultureInfo.CreateSpecificCulture("en-AU"), out decimal pricePerKilo);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                //currentRod = ((Rod)ComboMaterialName.SelectedItem);
                currentRod.CostPerKg = (double)pricePerKilo;
                currentFlat.CostPerKg = (double)pricePerKilo;
                currentHollowRod.CostPerKg = (double)pricePerKilo;
                
                ShowTotalPriceRaw();
            }
        }

        private void TxtPricePerKilo_LostFocus(object sender, EventArgs e)
        {
            
            switch (ComboMaterialType.SelectedIndex)
            {
                case 0:
                    TxtPricePerKilo.Text = string.Format("{0:C2}", currentRod.CostPerKg);
                    break;
                case 1:
                    TxtPricePerKilo.Text = string.Format("{0:C2}", currentHollowRod.CostPerKg);
                    break;
                case 2:
                    TxtPricePerKilo.Text = string.Format("{0:C2}", currentFlat.CostPerKg);
                    break;
            }
        }

        private void TxtQuantityRaw_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(TxtQty.Text, out double qty);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                //currentRod = ((Rod)ComboMaterialName.SelectedItem);
                currentRod.Qty = qty;
                currentFlat.Qty = qty;
                currentHollowRod.Qty = qty;
                ShowTotalPriceRaw();
            }
        }

        private void TxtQuantityRaw_LostFocus(object sender, EventArgs e)
        {
            
            switch (ComboMaterialType.SelectedIndex)
            {
                case 0:
                    TxtQty.Text = string.Format("{0:N}", currentRod.Qty);
                    break;
                case 1:
                    TxtQty.Text = string.Format("{0:N}", currentHollowRod.Qty);
                    break;
                case 2:
                    TxtQty.Text = string.Format("{0:N}", currentFlat.Qty);
                    break;
            }
        }

        private void TxtDensity_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(TxtDensity.Text, out double density);

            if (TxtDensity.TextLength > 0 && isNumeric)
            {
                //currentRod = ((Rod)ComboMaterialName.SelectedItem);
                currentRod.Density = density;
                currentFlat.Density = density;
                currentHollowRod.Density = density;
                //UpdateCurrentRod();
                ShowTotalPriceRaw();
            }
        }

        private void TxtDensity_LostFocus(object sender, EventArgs e)
        {
            switch (ComboMaterialType.SelectedIndex)
            {
                case 0:
                    TxtDensity.Text = string.Format("{0:F0}", currentRod.Density);
                    break;
                case 1:
                    TxtDensity.Text = string.Format("{0:F0}", currentHollowRod.Density);
                    break;
                case 2:
                    TxtDensity.Text = string.Format("{0:F0}", currentFlat.Density);
                    break;
            }
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
        private void UpdateCurrentFlat()
        {
            try
            {
                currentFlat.Name = TxtRawName.Text;
                currentFlat.Density = double.Parse(TxtDensity.Text);
                currentFlat.CostPerKg = double.Parse(TxtPricePerKilo.Text, NumberStyles.Currency);
                currentFlat.Qty = double.Parse(TxtQty.Text);
                currentFlat.Thickness = double.Parse(TxtThickness.Text);
                currentFlat.Length = double.Parse(TxtLength.Text);
                currentFlat.Width = double.Parse(TxtDiameter.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message);
            }
        }

        private void UpdateCurrentHollowRod()
        {
            try
            {
                currentHollowRod.Name = TxtRawName.Text;
                currentHollowRod.Density = double.Parse(TxtDensity.Text);
                currentHollowRod.CostPerKg = double.Parse(TxtPricePerKilo.Text, NumberStyles.Currency);
                currentHollowRod.Qty = double.Parse(TxtQty.Text);
                currentHollowRod.DiameterIn = double.Parse(TxtThickness.Text);
                currentHollowRod.Length = double.Parse(TxtLength.Text);
                currentHollowRod.DiameterOut = double.Parse(TxtDiameter.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message);
            }
        }

        private void ShowTotalPriceRaw()
        {
            switch(ComboMaterialType.SelectedIndex)
            {
                case 0:
                    currentRod.CalculateCost();
                    TxtUnitPrice.Text = string.Format("{0:C2}", currentRod.UnitCost);
                    TxtTotalPrice.Text = string.Format("{0:C2}", currentRod.TotalCost);
                    break;
                case 1:
                    currentHollowRod.CalculateCost();
                    TxtUnitPrice.Text = string.Format("{0:C2}", currentHollowRod.UnitCost);
                    TxtTotalPrice.Text = string.Format("{0:C2}", currentHollowRod.TotalCost);
                    break;
                case 2:
                    currentFlat.CalculateCost();
                    TxtUnitPrice.Text = string.Format("{0:C2}", currentFlat.UnitCost);
                    TxtTotalPrice.Text = string.Format("{0:C2}", currentFlat.TotalCost);
                    break;
                default:
                    break;
            }
            
        }

        private void TxtDensity_OnClick(object sender, EventArgs e)
        {
            TxtDensity.SelectAll();
        }

        private void TxtPricePerKilo_OnClick(object sender, EventArgs e)
        {
            TxtPricePerKilo.SelectAll();
        }

        private void TxtLength_OnClick(object sender, EventArgs e)
        {
            TxtLength.SelectAll();
        }

        private void TxtDiameter_OnClick(object sender, EventArgs e)
        {
            TxtDiameter.SelectAll();
        }

        private void TxtThickness_OnClick(object sender, EventArgs e)
        {
            TxtThickness.SelectAll();
        }

        private void TxtQty_OnClick(object sender, EventArgs e)
        {
            TxtQty.SelectAll();
        }

        private void TxtNameRaw_OnClick(object sender, EventArgs e)
        {
            TxtRawName.SelectAll();
        }
    }
}
