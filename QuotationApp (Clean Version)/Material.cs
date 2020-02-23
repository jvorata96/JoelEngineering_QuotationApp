using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotationApp__Clean_Version_
{
    public class Material
    {
        public double Qty { get; set; }
        public string Name { get; set; }
        public double Material_Cost { get; set; }
        public double Setup_Hr { get; set; }
        public double Setup_Cost { get; set; }
        public double Operation_Cost { get; set; }
        public double Operation_Hr { get; set; }
        public double Markup { get; set; }
        public double Id { get; set; }
        public double Grp_Id { get; set; }

        public double Price_Per_Piece { get; set; }
        public double SubProfit { get; set; }

        public void SetPricePerPiece()
        {
            Price_Per_Piece = SubTotal / Qty;
            SubProfit = (Price_Per_Piece * Markup / (1 + Markup)) * Qty;
        }

        public double SubTotal { get; set; }

        public void SetSubTotal()
        {
            SubTotal = Qty * ((1 + Markup) * (Material_Cost + (Setup_Hr * Setup_Cost / Qty) + (Operation_Hr * Operation_Cost)));
        }

        

        public Material()
        {
            //Name = "untitled";
            //Qty = 1;
        }

    }
}
