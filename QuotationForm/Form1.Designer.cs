﻿namespace QuotationForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ComboMaterialType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboMaterialName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSaveRawMaterial = new System.Windows.Forms.Button();
            this.BtnDeleteRawMaterial = new System.Windows.Forms.Button();
            this.TxtRawName = new System.Windows.Forms.TextBox();
            this.TxtDensity = new System.Windows.Forms.TextBox();
            this.TxtPricePerKilo = new System.Windows.Forms.TextBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.TxtLength = new System.Windows.Forms.TextBox();
            this.TxtDiameter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTotalPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtThickness = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ComboBoxProducts = new System.Windows.Forms.ComboBox();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.BtnDeleteProduct = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.DataGridMaterials = new System.Windows.Forms.DataGridView();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSetupCost = new System.Windows.Forms.TextBox();
            this.TxtOptnCost = new System.Windows.Forms.TextBox();
            this.TxtMaterialCost = new System.Windows.Forms.TextBox();
            this.TxtSetupHr = new System.Windows.Forms.TextBox();
            this.TxtOptnHr = new System.Windows.Forms.TextBox();
            this.TxtQtyQuote = new System.Windows.Forms.TextBox();
            this.BtnNewMaterial = new System.Windows.Forms.Button();
            this.BtnDeleteMaterial = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.TxtMarkup = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnSaveMaterial = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material Calculator";
            // 
            // ComboMaterialType
            // 
            this.ComboMaterialType.FormattingEnabled = true;
            this.ComboMaterialType.Items.AddRange(new object[] {
            "Rods",
            "Hollow Rods",
            "Flats"});
            this.ComboMaterialType.Location = new System.Drawing.Point(20, 49);
            this.ComboMaterialType.Margin = new System.Windows.Forms.Padding(4);
            this.ComboMaterialType.Name = "ComboMaterialType";
            this.ComboMaterialType.Size = new System.Drawing.Size(223, 24);
            this.ComboMaterialType.TabIndex = 1;
            this.ComboMaterialType.SelectedIndexChanged += new System.EventHandler(this.ComboMaterialType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // ComboMaterialName
            // 
            this.ComboMaterialName.FormattingEnabled = true;
            this.ComboMaterialName.Items.AddRange(new object[] {
            "Rods",
            "Hollow Rods",
            "Flats"});
            this.ComboMaterialName.Location = new System.Drawing.Point(20, 82);
            this.ComboMaterialName.Margin = new System.Windows.Forms.Padding(4);
            this.ComboMaterialName.Name = "ComboMaterialName";
            this.ComboMaterialName.Size = new System.Drawing.Size(223, 24);
            this.ComboMaterialName.TabIndex = 3;
            this.ComboMaterialName.SelectedIndexChanged += new System.EventHandler(this.ComboMaterialName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // BtnSaveRawMaterial
            // 
            this.BtnSaveRawMaterial.Location = new System.Drawing.Point(81, 464);
            this.BtnSaveRawMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSaveRawMaterial.Name = "BtnSaveRawMaterial";
            this.BtnSaveRawMaterial.Size = new System.Drawing.Size(100, 28);
            this.BtnSaveRawMaterial.TabIndex = 5;
            this.BtnSaveRawMaterial.Text = "Save";
            this.BtnSaveRawMaterial.UseVisualStyleBackColor = true;
            this.BtnSaveRawMaterial.Click += new System.EventHandler(this.BtnSaveRawMaterial_Click);
            // 
            // BtnDeleteRawMaterial
            // 
            this.BtnDeleteRawMaterial.Location = new System.Drawing.Point(81, 499);
            this.BtnDeleteRawMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDeleteRawMaterial.Name = "BtnDeleteRawMaterial";
            this.BtnDeleteRawMaterial.Size = new System.Drawing.Size(100, 28);
            this.BtnDeleteRawMaterial.TabIndex = 6;
            this.BtnDeleteRawMaterial.Text = "Delete";
            this.BtnDeleteRawMaterial.UseVisualStyleBackColor = true;
            this.BtnDeleteRawMaterial.Click += new System.EventHandler(this.BtnDeleteRawMaterial_Click);
            // 
            // TxtRawName
            // 
            this.TxtRawName.Location = new System.Drawing.Point(48, 434);
            this.TxtRawName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRawName.Name = "TxtRawName";
            this.TxtRawName.Size = new System.Drawing.Size(165, 22);
            this.TxtRawName.TabIndex = 14;
            this.TxtRawName.Text = "Enter name here";
            this.TxtRawName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRawName.Click += new System.EventHandler(this.TxtNameRaw_OnClick);
            // 
            // TxtDensity
            // 
            this.TxtDensity.Location = new System.Drawing.Point(20, 127);
            this.TxtDensity.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDensity.Name = "TxtDensity";
            this.TxtDensity.Size = new System.Drawing.Size(104, 22);
            this.TxtDensity.TabIndex = 8;
            this.TxtDensity.Click += new System.EventHandler(this.TxtDensity_OnClick);
            this.TxtDensity.TextChanged += new System.EventHandler(this.TxtDensity_TextChanged);
            this.TxtDensity.LostFocus += new System.EventHandler(this.TxtDensity_LostFocus);
            // 
            // TxtPricePerKilo
            // 
            this.TxtPricePerKilo.Location = new System.Drawing.Point(139, 127);
            this.TxtPricePerKilo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPricePerKilo.Name = "TxtPricePerKilo";
            this.TxtPricePerKilo.Size = new System.Drawing.Size(104, 22);
            this.TxtPricePerKilo.TabIndex = 9;
            this.TxtPricePerKilo.Click += new System.EventHandler(this.TxtPricePerKilo_OnClick);
            this.TxtPricePerKilo.TextChanged += new System.EventHandler(this.TxtPricePerKilo_TextChanged);
            this.TxtPricePerKilo.LostFocus += new System.EventHandler(this.TxtPricePerKilo_LostFocus);
            // 
            // TxtQty
            // 
            this.TxtQty.Location = new System.Drawing.Point(20, 314);
            this.TxtQty.Margin = new System.Windows.Forms.Padding(4);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(104, 22);
            this.TxtQty.TabIndex = 13;
            this.TxtQty.Click += new System.EventHandler(this.TxtQty_OnClick);
            this.TxtQty.TextChanged += new System.EventHandler(this.TxtQuantityRaw_TextChanged);
            this.TxtQty.LostFocus += new System.EventHandler(this.TxtQuantityRaw_LostFocus);
            // 
            // TxtLength
            // 
            this.TxtLength.Location = new System.Drawing.Point(20, 186);
            this.TxtLength.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLength.Name = "TxtLength";
            this.TxtLength.Size = new System.Drawing.Size(104, 22);
            this.TxtLength.TabIndex = 10;
            this.TxtLength.Click += new System.EventHandler(this.TxtLength_OnClick);
            this.TxtLength.TextChanged += new System.EventHandler(this.TxtLength_TextChanged);
            this.TxtLength.LostFocus += new System.EventHandler(this.TxtLength_LostFocus);
            // 
            // TxtDiameter
            // 
            this.TxtDiameter.Location = new System.Drawing.Point(139, 186);
            this.TxtDiameter.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDiameter.Name = "TxtDiameter";
            this.TxtDiameter.Size = new System.Drawing.Size(104, 22);
            this.TxtDiameter.TabIndex = 11;
            this.TxtDiameter.Click += new System.EventHandler(this.TxtDiameter_OnClick);
            this.TxtDiameter.TextChanged += new System.EventHandler(this.TxtDiameter_TextChanged);
            this.TxtDiameter.LostFocus += new System.EventHandler(this.TxtDiameter_LostFocus);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Density";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Diameter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Length";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 342);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Price/Kilo";
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Location = new System.Drawing.Point(139, 314);
            this.TxtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.ReadOnly = true;
            this.TxtUnitPrice.Size = new System.Drawing.Size(104, 22);
            this.TxtUnitPrice.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 342);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Unit Price";
            // 
            // TxtTotalPrice
            // 
            this.TxtTotalPrice.Location = new System.Drawing.Point(77, 374);
            this.TxtTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTotalPrice.Name = "TxtTotalPrice";
            this.TxtTotalPrice.ReadOnly = true;
            this.TxtTotalPrice.Size = new System.Drawing.Size(104, 22);
            this.TxtTotalPrice.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 402);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total Price";
            // 
            // TxtThickness
            // 
            this.TxtThickness.Location = new System.Drawing.Point(77, 245);
            this.TxtThickness.Margin = new System.Windows.Forms.Padding(4);
            this.TxtThickness.Name = "TxtThickness";
            this.TxtThickness.Size = new System.Drawing.Size(104, 22);
            this.TxtThickness.TabIndex = 12;
            this.TxtThickness.Click += new System.EventHandler(this.TxtThickness_OnClick);
            this.TxtThickness.TextChanged += new System.EventHandler(this.TxtThickness_TextChanged);
            this.TxtThickness.LostFocus += new System.EventHandler(this.TxtThickness_LostFocus);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 273);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Thickness";
            // 
            // ComboBoxProducts
            // 
            this.ComboBoxProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxProducts.FormattingEnabled = true;
            this.ComboBoxProducts.Items.AddRange(new object[] {
            "Rods",
            "Hollow Rods",
            "Flats"});
            this.ComboBoxProducts.Location = new System.Drawing.Point(326, 42);
            this.ComboBoxProducts.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxProducts.Name = "ComboBoxProducts";
            this.ComboBoxProducts.Size = new System.Drawing.Size(255, 24);
            this.ComboBoxProducts.TabIndex = 24;
            this.ComboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProducts_SelectedIndexChanged);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Location = new System.Drawing.Point(622, 42);
            this.BtnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(100, 28);
            this.BtnAddProduct.TabIndex = 25;
            this.BtnAddProduct.Text = "New";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.Location = new System.Drawing.Point(734, 42);
            this.BtnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(100, 28);
            this.BtnDeleteProduct.TabIndex = 26;
            this.BtnDeleteProduct.Text = "Delete";
            this.BtnDeleteProduct.UseVisualStyleBackColor = true;
            this.BtnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(583, 45);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Job";
            // 
            // DataGridMaterials
            // 
            this.DataGridMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMaterials.Location = new System.Drawing.Point(326, 86);
            this.DataGridMaterials.Name = "DataGridMaterials";
            this.DataGridMaterials.RowHeadersVisible = false;
            this.DataGridMaterials.RowHeadersWidth = 51;
            this.DataGridMaterials.RowTemplate.Height = 24;
            this.DataGridMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridMaterials.Size = new System.Drawing.Size(508, 324);
            this.DataGridMaterials.TabIndex = 28;
            this.DataGridMaterials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMaterials_CellClick);
            this.DataGridMaterials.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridMaterials_KeyDown);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(326, 425);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(104, 22);
            this.TxtName.TabIndex = 29;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtSetupCost
            // 
            this.TxtSetupCost.Location = new System.Drawing.Point(461, 425);
            this.TxtSetupCost.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSetupCost.Name = "TxtSetupCost";
            this.TxtSetupCost.Size = new System.Drawing.Size(104, 22);
            this.TxtSetupCost.TabIndex = 31;
            this.TxtSetupCost.TextChanged += new System.EventHandler(this.TxtSetupCost_TextChanged);
            // 
            // TxtOptnCost
            // 
            this.TxtOptnCost.Location = new System.Drawing.Point(597, 425);
            this.TxtOptnCost.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOptnCost.Name = "TxtOptnCost";
            this.TxtOptnCost.Size = new System.Drawing.Size(104, 22);
            this.TxtOptnCost.TabIndex = 33;
            this.TxtOptnCost.TextChanged += new System.EventHandler(this.TxtOptnCost_TextChanged);
            // 
            // TxtMaterialCost
            // 
            this.TxtMaterialCost.Location = new System.Drawing.Point(326, 486);
            this.TxtMaterialCost.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMaterialCost.Name = "TxtMaterialCost";
            this.TxtMaterialCost.Size = new System.Drawing.Size(104, 22);
            this.TxtMaterialCost.TabIndex = 30;
            this.TxtMaterialCost.TextChanged += new System.EventHandler(this.TxtUnitPriceQuote_TextChanged);
            // 
            // TxtSetupHr
            // 
            this.TxtSetupHr.Location = new System.Drawing.Point(461, 486);
            this.TxtSetupHr.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSetupHr.Name = "TxtSetupHr";
            this.TxtSetupHr.Size = new System.Drawing.Size(104, 22);
            this.TxtSetupHr.TabIndex = 32;
            this.TxtSetupHr.TextChanged += new System.EventHandler(this.TxtSetupHr_TextChanged);
            // 
            // TxtOptnHr
            // 
            this.TxtOptnHr.Location = new System.Drawing.Point(597, 486);
            this.TxtOptnHr.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOptnHr.Name = "TxtOptnHr";
            this.TxtOptnHr.Size = new System.Drawing.Size(104, 22);
            this.TxtOptnHr.TabIndex = 34;
            this.TxtOptnHr.TextChanged += new System.EventHandler(this.TxtOptnHr_TextChanged);
            // 
            // TxtQtyQuote
            // 
            this.TxtQtyQuote.Location = new System.Drawing.Point(730, 425);
            this.TxtQtyQuote.Margin = new System.Windows.Forms.Padding(4);
            this.TxtQtyQuote.Name = "TxtQtyQuote";
            this.TxtQtyQuote.Size = new System.Drawing.Size(104, 22);
            this.TxtQtyQuote.TabIndex = 35;
            this.TxtQtyQuote.TextChanged += new System.EventHandler(this.TxtQtyQuote_TextChanged);
            // 
            // BtnNewMaterial
            // 
            this.BtnNewMaterial.Location = new System.Drawing.Point(861, 282);
            this.BtnNewMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewMaterial.Name = "BtnNewMaterial";
            this.BtnNewMaterial.Size = new System.Drawing.Size(104, 28);
            this.BtnNewMaterial.TabIndex = 38;
            this.BtnNewMaterial.Text = "New";
            this.BtnNewMaterial.UseVisualStyleBackColor = true;
            this.BtnNewMaterial.Click += new System.EventHandler(this.BtnNewMaterial_Click);
            // 
            // BtnDeleteMaterial
            // 
            this.BtnDeleteMaterial.Location = new System.Drawing.Point(859, 368);
            this.BtnDeleteMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDeleteMaterial.Name = "BtnDeleteMaterial";
            this.BtnDeleteMaterial.Size = new System.Drawing.Size(104, 28);
            this.BtnDeleteMaterial.TabIndex = 39;
            this.BtnDeleteMaterial.Text = "Delete";
            this.BtnDeleteMaterial.UseVisualStyleBackColor = true;
            this.BtnDeleteMaterial.Click += new System.EventHandler(this.BtnDeleteMaterial_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 451);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Material Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(477, 451);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "Setup $/Hr";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(750, 451);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 17);
            this.label15.TabIndex = 40;
            this.label15.Text = "Quantity";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(893, 112);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(754, 512);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 17);
            this.label17.TabIndex = 42;
            this.label17.Text = "Markup";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(604, 512);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 17);
            this.label18.TabIndex = 43;
            this.label18.Text = "Operation Hr";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(599, 451);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 17);
            this.label19.TabIndex = 44;
            this.label19.Text = "Operation $/Hr";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(335, 512);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 17);
            this.label20.TabIndex = 45;
            this.label20.Text = "Material Cost";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(479, 512);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 17);
            this.label21.TabIndex = 46;
            this.label21.Text = "Setup  Hr";
            // 
            // TxtMarkup
            // 
            this.TxtMarkup.Location = new System.Drawing.Point(730, 486);
            this.TxtMarkup.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMarkup.Name = "TxtMarkup";
            this.TxtMarkup.Size = new System.Drawing.Size(104, 22);
            this.TxtMarkup.TabIndex = 36;
            this.TxtMarkup.TextChanged += new System.EventHandler(this.TxtMarkup_TextChanged);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(859, 133);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(104, 22);
            this.TxtTotal.TabIndex = 48;
            // 
            // BtnSaveMaterial
            // 
            this.BtnSaveMaterial.Location = new System.Drawing.Point(859, 325);
            this.BtnSaveMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSaveMaterial.Name = "BtnSaveMaterial";
            this.BtnSaveMaterial.Size = new System.Drawing.Size(104, 28);
            this.BtnSaveMaterial.TabIndex = 37;
            this.BtnSaveMaterial.Text = "Save";
            this.BtnSaveMaterial.UseVisualStyleBackColor = true;
            this.BtnSaveMaterial.Click += new System.EventHandler(this.BtnSaveMaterial_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(859, 425);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(104, 22);
            this.textBox1.TabIndex = 49;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(859, 486);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(104, 22);
            this.textBox2.TabIndex = 50;
            this.textBox2.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(879, 451);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 17);
            this.label22.TabIndex = 51;
            this.label22.Text = "Unit Cost";
            this.label22.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(881, 512);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 17);
            this.label23.TabIndex = 52;
            this.label23.Text = "SubTotal";
            this.label23.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 554);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSaveMaterial);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtMarkup);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BtnDeleteMaterial);
            this.Controls.Add(this.BtnNewMaterial);
            this.Controls.Add(this.TxtQtyQuote);
            this.Controls.Add(this.TxtOptnHr);
            this.Controls.Add(this.TxtSetupHr);
            this.Controls.Add(this.TxtMaterialCost);
            this.Controls.Add(this.TxtOptnCost);
            this.Controls.Add(this.TxtSetupCost);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.DataGridMaterials);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnDeleteProduct);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.ComboBoxProducts);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtThickness);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtTotalPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtUnitPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDiameter);
            this.Controls.Add(this.TxtLength);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.TxtPricePerKilo);
            this.Controls.Add(this.TxtDensity);
            this.Controls.Add(this.TxtRawName);
            this.Controls.Add(this.BtnDeleteRawMaterial);
            this.Controls.Add(this.BtnSaveRawMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboMaterialName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboMaterialType);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboMaterialType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboMaterialName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSaveRawMaterial;
        private System.Windows.Forms.Button BtnDeleteRawMaterial;
        private System.Windows.Forms.TextBox TxtRawName;
        private System.Windows.Forms.TextBox TxtDensity;
        private System.Windows.Forms.TextBox TxtPricePerKilo;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.TextBox TxtLength;
        private System.Windows.Forms.TextBox TxtDiameter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtTotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtThickness;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ComboBoxProducts;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Button BtnDeleteProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DataGridMaterials;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSetupCost;
        private System.Windows.Forms.TextBox TxtOptnCost;
        private System.Windows.Forms.TextBox TxtMaterialCost;
        private System.Windows.Forms.TextBox TxtSetupHr;
        private System.Windows.Forms.TextBox TxtOptnHr;
        private System.Windows.Forms.TextBox TxtQtyQuote;
        private System.Windows.Forms.Button BtnNewMaterial;
        private System.Windows.Forms.Button BtnDeleteMaterial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TxtMarkup;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnSaveMaterial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

