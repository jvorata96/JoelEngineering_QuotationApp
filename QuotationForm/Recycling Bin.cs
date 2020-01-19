using QuotationApp__Clean_Version_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuotationForm
{
    public partial class Recycling_Bin : Form
    {
        public Recycling_Bin(List<Material> recyclingProducts)
        {
            InitializeComponent();

            ComboBoxRecycle.DisplayMember = "Name";
            ComboBoxRecycle.ValueMember = "Id";
            ComboBoxRecycle.DataSource = recyclingProducts;
            ComboBoxRecycle.SelectedItem = ComboBoxRecycle.Items[ComboBoxRecycle.Items.Count - 1];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
