using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuotationApp__Clean_Version_;

namespace QuotationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RawMaterial shape = new Rod("Rod1", 1.23, 2, 3, 4, 6);
            shape.CalculateCost();
            shape.Density = 0;
            shape.Name = "he";

            //Console.WriteLine(shape.UnitCost.ToString());
            Console.WriteLine("hey" + shape.TotalCost.ToString());
        }
    }
}
