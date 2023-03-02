using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket
{
    internal class Pickup : Car, IMakeCar
    {
        private bool _hasTruckCover;
        public Pickup(double price)
            : base(price)
        {
            MakeCar();
            GetFuelConsumption(10, 15);
        }

        public bool HasTruckCover
        {
            get { return _hasTruckCover; }
            set { _hasTruckCover = value; }
        }

        public new void MakeCar()
        {
            Random rand = new Random();
            if (rand.Next(0, 100) < 50)
            {
                _hasTruckCover = true;
            }
            else
            {
                _hasTruckCover = false;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"; HasTruckCover: {HasTruckCover}";
        }
    }
}
