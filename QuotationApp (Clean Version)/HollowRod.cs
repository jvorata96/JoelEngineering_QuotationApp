using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotationApp__Clean_Version_
{
    class HollowRod : RawMaterial
    {
        private double _diameterOut;
        private double _diameterIn;
        private double _length;
        public HollowRod(string name, double density, double costPerKg, double qty, double diameterOut, double diameterIn, double length)
            : base(name, density, costPerKg, qty)
        {
            DiameterOut = diameterOut;
            DiameterIn = diameterIn;
            Length = length;
        }
        public double DiameterOut
        {
            get { return _diameterOut; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Error: Outer diameter should be greater than 0.");
                else if (value <= DiameterIn)
                    throw new ArgumentException("Error: Outer diameter should be greater than inner diameter.");
                _diameterOut = value;
            }
        }
        public double DiameterIn
        {
            get { return _diameterIn; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Error: Inner diameter should be greater than 0.");
                else if (value >= DiameterIn)
                    throw new ArgumentException("Error: Outer diameter should be greater than inner diameter.");
                _diameterIn = value;
            }
        }
        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Error: Length should be greater than 0.");
                _length = value;
            }
        }
        public override void CalculateCost()
        {
            UnitCost = (Math.PI * Math.Pow((DiameterOut - DiameterIn) / 2, 2) * Length * Density * CostPerKg);
            TotalCost = UnitCost * Qty;
        }
    }
}