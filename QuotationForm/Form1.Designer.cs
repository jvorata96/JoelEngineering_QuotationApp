namespace QuotationForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.BtnSaveRawMaterial.Location = new System.Drawing.Point(80, 466);
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
            this.BtnDeleteRawMaterial.Location = new System.Drawing.Point(80, 502);
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
            this.ComboBoxProducts.FormattingEnabled = true;
            this.ComboBoxProducts.Items.AddRange(new object[] {
            "Rods",
            "Hollow Rods",
            "Flats"});
            this.ComboBoxProducts.Location = new System.Drawing.Point(326, 14);
            this.ComboBoxProducts.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxProducts.Name = "ComboBoxProducts";
            this.ComboBoxProducts.Size = new System.Drawing.Size(228, 24);
            this.ComboBoxProducts.TabIndex = 24;
            this.ComboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProducts_SelectedIndexChanged);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Location = new System.Drawing.Point(601, 14);
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
            this.BtnDeleteProduct.Location = new System.Drawing.Point(601, 45);
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
            this.label12.Location = new System.Drawing.Point(562, 17);
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
            this.DataGridMaterials.Size = new System.Drawing.Size(375, 301);
            this.DataGridMaterials.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(326, 402);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 22);
            this.textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(461, 402);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 22);
            this.textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(597, 402);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 22);
            this.textBox3.TabIndex = 31;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(326, 466);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(104, 22);
            this.textBox4.TabIndex = 32;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(461, 466);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(104, 22);
            this.textBox5.TabIndex = 33;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(597, 466);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(104, 22);
            this.textBox6.TabIndex = 34;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(326, 519);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(104, 22);
            this.textBox7.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 516);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 36;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 516);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 28);
            this.button2.TabIndex = 37;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

