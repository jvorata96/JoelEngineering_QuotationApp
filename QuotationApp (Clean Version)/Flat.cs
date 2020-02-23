using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotationApp__Clean_Version_
{
    public class Flat : RawMaterial
    {
        private double _width;
        private double _thickness;
        private double _length;
        public Flat(string name, double density, double costPerKg, double qty, double width, double thickness, double length)
            : base(name, density, costPerKg, qty)
        {
            Width = width;
            Thickness = thickness;
            Length = length;
        }
        public double Width
        {
            get { return _width; }
            set
            {
                //if (value <= 0)
                //    throw new ArgumentException("Error: Width should be greater than 0.");
                _width = value;
            }
        }
        public double Thickness
        {
            get { return _thickness; }
            set
            {
                //if (value <= 0)
                //    throw new ArgumentException("Error: Thickness should be greater than 0.");
                _thickness = value;
            }
        }
        public double Length
        {
            get { return _length; }
            set
            {
                //if (value <= 0)
                //    throw new ArgumentException("Error: Length should be greater than 0.");
                _length = value;
            }
        }
        public override void CalculateCost()
        {
            UnitCost = (Width * Thickness * Length * Density * CostPerKg) / 1000000000;
            TotalCost = UnitCost * Qty;
        }
    }
}
