using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotationApp__Clean_Version_
{
    public abstract class RawMaterial
    {
        private string _name;
        private double _density;
        private double _costPerKg;
        private double _qty;

        public RawMaterial(string name, double density, double costPerKg, double qty)
        {
            Name = name;
            Density = density;
            CostPerKg = costPerKg;
            Qty = qty;
        }
        public string Name 
        {   get { return _name; } 
            set
            {
                //if (value == null)
                //    throw new ArgumentNullException("Error: Name is required.");
                //else if (String.IsNullOrWhiteSpace(value))
                //    throw new ArgumentException("Error: Name cannot consist of only white space.");
                _name = value;
            }
        }
        public double Density
        {
            get { return _density; }
            set
            {
                //if (value <= 0)
                //    throw new ArgumentException("Error: Density should be greater than 0.");
                _density = value;
            }
        }
        public double CostPerKg 
        {
            get { return _costPerKg; }
            set
            {
                //if (value < 0)
                //    throw new ArgumentException("Error: Cost/Kg cannot be negative.");
                _costPerKg = value;
            }
        }
        public double Qty
        {
            get { return _qty; }
            set
            {
                //if (value < 0)
                //    throw new ArgumentException("Error: Quantity cannot be negative.");
                _qty = value;
            }
        }
        public double Id { get; set; }
        public double UnitCost { get; protected set; }
        public double TotalCost { get; protected set; }
        public abstract void CalculateCost();
    }
}
