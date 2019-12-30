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
        private SQLQuery sQLQuery;

        //***************FIELDS OF MATERIAL CALCULATOR**********************
        private enum _materialType {Rods, HollowRods, Flats};
        private readonly List<_materialType> _materialTypes = new List<_materialType>{_materialType.Rods, _materialType.HollowRods, _materialType.Flats };

        List<RawMaterial> rawMaterials;

        private Rod currentRod = new Rod("Blank", 1, 1, 1, 1, 1);
        private Flat currentFlat = new Flat("BlankFlat", 1, 1, 1, 1, 1, 1);
        private HollowRod currentHollowRod = new HollowRod("BlankHollow", 1, 1, 1, 1, 1, 1);

        //***************FIELDS OF QUOTATION**********************
        private List<Material> productList;
        private List<Material> materialList;
        private Material currentProduct;
        private Material currentMaterial;

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

            sQLQuery.GetProducts();
            productList = new List<Material>(sQLQuery.ProductList);

            ComboBoxProducts.DisplayMember = "Name";
            ComboBoxProducts.ValueMember = "Id";
            ComboBoxProducts.DataSource = productList;
        }

        //***************START OF MATERIAL CALCULATOR**********************

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
                    label5.Text = "Length";
                    label5.Location = new Point(162, 195);

                    label6.Text = "Diameter";
                    label6.Location = new Point(72, 195);

                    sQLQuery.GetRods();
                    rawMaterials = new List<RawMaterial>(sQLQuery.RodList);

                    label11.Visible = false;
                    TxtThickness.Visible = false;

                    TxtLength.Location = new Point(145, 172);

                    break;
                case 1:
                    Print("Hollows");
                    label11.Visible = true;
                    label11.Text = "Length";
                    label11.Location = new Point(120,241);

                    label5.Text = "Inner Diameter";
                    label5.Location = new Point(147, 195);
                    
                    label6.Text = "Outer Diameter";
                    label6.Location = new Point(58, 195);
                    TxtThickness.Visible = true;

                    TxtThickness.Location = new Point(145, 172);
                    TxtLength.Location = new Point(99, 217);

                    sQLQuery.GetHollowRods();
                    rawMaterials = new List<RawMaterial>(sQLQuery.HollowRodList);

                    break;
                case 2:
                    Print("Flats");
                    label11.Visible = true;
                    label11.Text = "Length";
                    label11.Location = new Point(120, 241);

                    label5.Text = "Width";
                    label5.Location = new Point(167, 195);
                    TxtThickness.Visible = true;

                    label6.Text = "Thickness";
                    label6.Location = new Point(70, 195);
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
                    BtnDeleteRawMaterial.Visible = false;
                    Print("selected New************************222*");
                    currentRod = new Rod("Blank", 1, 1, 1, 1, 1);
                    currentFlat = new Flat("Blank", 1, 1, 1, 1, 1, 1);
                    currentHollowRod = new HollowRod("BlankHollow", 1, 1, 1, 1, 1, 1);
                    TxtRawName.Text = "Enter Material Name Here";
                    //TxtRawName.Clear();
                    TxtDensity.Clear();
                    TxtPricePerKilo.Clear();
                    TxtQty.Clear();
                    TxtLength.Clear();
                    TxtDiameter.Clear();
                    TxtThickness.Clear();
                    TxtUnitPrice.Clear();
                    TxtTotalPrice.Clear();
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
                    Print("balik visible delete");
                    BtnDeleteRawMaterial.Visible = true;
                }

                //var currentMaterial = (Rod)ComboMaterialName.SelectedItem;

                
            }
        }

        private void BtnSaveRawMaterial_Click(object sender, EventArgs e)
        {
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
                    TxtDensity.Text = string.Format("{0:F}", currentRod.Density);
                    break;
                case 1:
                    TxtDensity.Text = string.Format("{0:F}", currentHollowRod.Density);
                    break;
                case 2:
                    TxtDensity.Text = string.Format("{0:F}", currentFlat.Density);
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

        //***************END OF MATERIAL CALCULATOR**********************

        //***************PRODUCT FUNTIONS**********************
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            var productName = ShowMyDialogBox();
            if (productName.Length > 0)
            {
                //if (!IsProductAlreadyExist())
                //{
                    Material material = new Material
                    {
                        Name = productName,
                    };

                    sQLQuery.AddProduct(material);
                    DisplayProducts();
                //}
                //else
                //{
                //    MessageBox.Show("Product Name already exists");
                //}

            }
            else
            {
                MessageBox.Show("Please enter Product Name");
            }
            
        }

        private void DisplayProducts()
        {
            sQLQuery.GetProducts();

            productList = new List<Material>(sQLQuery.ProductList);

            ComboBoxProducts.DisplayMember = "Name";
            ComboBoxProducts.ValueMember = "Id";
            ComboBoxProducts.DataSource = productList;
            ComboBoxProducts.SelectedItem = ComboBoxProducts.Items[ComboBoxProducts.Items.Count - 1];
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            sQLQuery.DeleteProduct(currentProduct.Id);
            DisplayProducts();
        }

        public string ShowMyDialogBox()
        {
            Form2 testDialog = new Form2();
            testDialog.StartPosition = FormStartPosition.CenterParent;
            testDialog.Text = "Enter Job Name:";
            var name = "blank";
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                name = testDialog.TextBox1.Text.ToString();
            }
            else
            {
                name = testDialog.TextBox1.Text.ToString();
            }
            
            testDialog.Dispose();
            return name;
        }

        private void ComboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxProducts.SelectedIndex != -1)
            {
                currentProduct = (Material)ComboBoxProducts.SelectedItem;
                Console.WriteLine("Selected Product ID: " + currentProduct.Id.ToString());
                DisplayQuoteMaterials();
            }
            else
            {
                currentProduct = new Material();    //WTF IS THIS? TEST IT WHEN ALL PRODUCTS ARE DELETED OR BEGIN APP WITH EMPTY PRODUCTS
            }
        }
        //*****************MATERIAL FUNCTIONS*****************//
        private void DisplayQuoteMaterials()
        {

            sQLQuery.GetMaterials(currentProduct.Id);

            materialList = new List<Material>(sQLQuery.MaterialList);


            DataGridMaterials.DataSource = null;
            DataGridMaterials.DataSource = materialList;

            DataGridMaterials.AutoResizeColumns();

            DataGridMaterials.Columns["SubTotal"].DefaultCellStyle.Format = "C2";
            DataGridMaterials.Columns["Price_Per_Piece"].DefaultCellStyle.Format = "C2";
            DataGridMaterials.Columns["Subtotal"].HeaderText = "SubTotal";
            DataGridMaterials.Columns["Price_Per_Piece"].HeaderText = "Unit Price";
            DataGridMaterials.Columns["Qty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataGridMaterials.Columns["Qty"].ReadOnly = true;
            DataGridMaterials.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridMaterials.Columns["Name"].HeaderText = "Material Name";
            DataGridMaterials.Columns["Name"].ReadOnly = true;
            DataGridMaterials.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataGridMaterials.Columns["SubTotal"].ReadOnly = true;
            DataGridMaterials.Columns["Price_Per_Piece"].ReadOnly = true;
            DataGridMaterials.Columns["Price_Per_Piece"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataGridMaterials.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridMaterials.Columns["Qty"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridMaterials.Columns["SubTotal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridMaterials.Columns["Price_Per_Piece"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridMaterials.Columns["Material_Cost"].Visible = false;
            DataGridMaterials.Columns["Material_Cost"].Visible = false;
            //DataGridMaterials.Columns["Price_Per_Piece"].Visible = false;
            DataGridMaterials.Columns["Setup_Hr"].Visible = false;
            DataGridMaterials.Columns["Setup_Cost"].Visible = false;
            DataGridMaterials.Columns["Operation_Cost"].Visible = false;
            DataGridMaterials.Columns["Operation_Hr"].Visible = false;
            DataGridMaterials.Columns["Markup"].Visible = false;
            DataGridMaterials.Columns["Id"].Visible = false;
            DataGridMaterials.Columns["Grp_Id"].Visible = false;
            

            DataGridMaterials.ClearSelection();
            DisplayTotal();
            
        }

        private void DisplayTotal()
        {
            sQLQuery.CalculateTotal();
            //var culture = new CultureInfo("en-AU");
            TxtTotal.Text = string.Format("{0:C2}", sQLQuery.Total);
        }

        private bool AreAllFilledOut()
        {
            return (TxtQtyQuote.Text.Length > 0 && TxtMaterialCost.Text.Length > 0
                && TxtMarkup.Text.Length > 0 && TxtSetupCost.Text.Length > 0
                && TxtSetupHr.Text.Length > 0 && TxtOptnCost.Text.Length > 0
                && TxtOptnHr.Text.Length > 0 && TxtName.Text.Length > 0) ? true : false;
        }

        private void UpdateCurrentMaterial()
        {
            if (DataGridMaterials.SelectedRows.Count > 0)
            {
                try
                {
                    currentMaterial = new Material
                    {
                        Name = TxtName.Text,
                        Qty = double.Parse(TxtQtyQuote.Text),
                        //Material_Cost = double.Parse(TxtMaterialCost.Text, NumberStyles.Any),
                        Material_Cost = double.Parse(TxtMaterialCost.Text, NumberStyles.Any),
                        Markup = double.Parse(TxtMarkup.Text),
                        Setup_Cost = double.Parse(TxtSetupCost.Text, NumberStyles.Any),
                        Setup_Hr = double.Parse(TxtSetupHr.Text),
                        Operation_Cost = double.Parse(TxtOptnCost.Text, NumberStyles.Any),
                        Operation_Hr = double.Parse(TxtOptnHr.Text),
                        Grp_Id = ((Material)ComboBoxProducts.SelectedItem).Id,
                        Id = ((Material)DataGridMaterials.SelectedRows[0].DataBoundItem).Id
                    };
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
            else
            {
                Print("walang selected");
                try
                {
                    currentMaterial = new Material
                    {
                        Name = TxtName.Text,
                        Qty = double.Parse(TxtQtyQuote.Text),
                        Material_Cost = double.Parse(TxtMaterialCost.Text, NumberStyles.Any),
                        Markup = double.Parse(TxtMarkup.Text),
                        Setup_Cost = double.Parse(TxtSetupCost.Text, NumberStyles.Any),
                        Setup_Hr = double.Parse(TxtSetupHr.Text),
                        Operation_Cost = double.Parse(TxtOptnCost.Text, NumberStyles.Any),
                        Operation_Hr = double.Parse(TxtOptnHr.Text),
                        Grp_Id = ((Material)ComboBoxProducts.SelectedItem).Id,
                        Id = 0
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
            
        }

        private void DataGridMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    currentMaterial = DataGridMaterials.SelectedRows[0].DataBoundItem as Material;
                    //oldname = selectedmaterial.name;
                    TxtName.Text = currentMaterial.Name;
                    TxtMaterialCost.Text = string.Format("{0:C2}", currentMaterial.Material_Cost);
                    TxtSetupCost.Text = string.Format("{0:C2}", currentMaterial.Setup_Cost);
                    TxtSetupHr.Text = currentMaterial.Setup_Hr.ToString();
                    TxtQtyQuote.Text = currentMaterial.Qty.ToString();
                    TxtOptnCost.Text = string.Format("{0:C2}", currentMaterial.Operation_Cost);
                    TxtOptnHr.Text = currentMaterial.Operation_Hr.ToString();
                    TxtMarkup.Text = currentMaterial.Markup.ToString();
                    //UpdateCurrentMaterial();
                    //lockmodify = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUnitPriceQuote_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSetupCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSetupHr_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtOptnCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtOptnHr_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtQtyQuote_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMarkup_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNewMaterial_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtQtyQuote.Clear();
            TxtMaterialCost.Clear();
            TxtMarkup.Clear();
            TxtSetupCost.Clear();
            TxtSetupHr.Clear();
            TxtOptnCost.Clear();
            TxtOptnHr.Clear();
            TxtQtyQuote.Text = "1";
            TxtSetupCost.Text = string.Format("{0:C2}", 50);
            TxtOptnCost.Text = string.Format("{0:C2}", 75);
            TxtSetupHr.Text = "0";
            TxtOptnHr.Text = "0";
            TxtMaterialCost.Text = "1";
            TxtMarkup.Text = "0";
            TxtName.Text = "Enter name here...";
            DataGridMaterials.ClearSelection();
            //UpdateCurrentMaterial();

            //lockAdd = false;
            //lockModify = true;
        }

        private void BtnSaveMaterial_Click(object sender, EventArgs e)
        {
            //if(AreAllFilledOut())
            //{
            //    UpdateCurrentMaterial();
            //    sQLQuery.AddMaterial(currentMaterial);
            //    DisplayQuoteMaterials();
            //}
            //else
            //{
            //    MessageBox.Show("Missing Fields");
            //}
            if (AreAllFilledOut())
            {
                try
                {
                    UpdateCurrentMaterial();
                    if (currentMaterial.Id == 0)
                    {
                        sQLQuery.AddMaterial(currentMaterial);
                    }
                    else
                    {
                        sQLQuery.ModifyMaterial(currentMaterial);
                    }
                    DisplayQuoteMaterials();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + ex.Source);
                }
            }
            else
            {
                MessageBox.Show("Missing Fields");
            }

        }

        private void BtnDeleteMaterial_Click(object sender, EventArgs e)
        {
            if(DataGridMaterials.SelectedRows.Count > 0)
            {
                sQLQuery.DeleteMaterial(currentMaterial.Id);

                DisplayQuoteMaterials();
            }
            else
            {
                MessageBox.Show("Please select a Material to delete above.");
            }
        }

        private void DataGridMaterials_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyData & Keys.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                default:
                    break;
            }
        }



        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Utilities utilities = new Utilities();

            utilities.ExportToExcel(materialList, sQLQuery.Total, currentProduct.Name);
        }

        private void TxtSetupCost_Click(object sender, EventArgs e)
        {
            TxtSetupCost.SelectAll();
        }

        private void TxtSetupHr_Click(object sender, EventArgs e)
        {
            TxtSetupHr.SelectAll();
        }

        private void TxtOptnCost_Click(object sender, EventArgs e)
        {
            TxtOptnCost.SelectAll();
        }

        private void TxtOptnHr_Click(object sender, EventArgs e)
        {
            TxtOptnHr.SelectAll();
        }

        private void TxtQtyQuote_Click(object sender, EventArgs e)
        {
            TxtQtyQuote.SelectAll();
        }

        private void TxtMarkup_Click(object sender, EventArgs e)
        {
            TxtMarkup.SelectAll();
        }

        private void TxtMaterialCost_Click(object sender, EventArgs e)
        {
            TxtMaterialCost.SelectAll();
        }
    }
}
