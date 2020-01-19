namespace QuotationForm
{
    partial class Recycling_Bin
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
            this.ComboBoxRecycle = new System.Windows.Forms.ComboBox();
            this.BtnRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxRecycle
            // 
            this.ComboBoxRecycle.FormattingEnabled = true;
            this.ComboBoxRecycle.Location = new System.Drawing.Point(12, 12);
            this.ComboBoxRecycle.Name = "ComboBoxRecycle";
            this.ComboBoxRecycle.Size = new System.Drawing.Size(518, 21);
            this.ComboBoxRecycle.TabIndex = 0;
            this.ComboBoxRecycle.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnRestore
            // 
            this.BtnRestore.Location = new System.Drawing.Point(536, 12);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(75, 23);
            this.BtnRestore.TabIndex = 1;
            this.BtnRestore.Text = "Restore";
            this.BtnRestore.UseVisualStyleBackColor = true;
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // Recycling_Bin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 45);
            this.Controls.Add(this.BtnRestore);
            this.Controls.Add(this.ComboBoxRecycle);
            this.Name = "Recycling_Bin";
            this.Text = "Recycling_Bin";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox ComboBoxRecycle;
        public System.Windows.Forms.Button BtnRestore;
    }
}