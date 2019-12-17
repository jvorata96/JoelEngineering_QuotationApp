using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotationApp__Clean_Version_
{
    public sealed class Rod : RawMaterial
    {
        private double _diameter;
        private double _length;
        public Rod(string name, double density, double costPerKg, double qty, double diameter, double length)
            : base(name, density, costPerKg, qty)
        {
            Diameter = diameter;
            Length = length;
        }
        public double Diameter
        {
            get { return _diameter; }
            set
            {
                //if (value <= 0)
                //    throw new ArgumentException("Error: Diameter should be greater than 0.");
                _diameter = value;
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
            UnitCost = (Math.PI * Math.Pow(Diameter / 2, 2) * Length * Density * CostPerKg);
            TotalCost = UnitCost * Qty;
        }
    }
}
