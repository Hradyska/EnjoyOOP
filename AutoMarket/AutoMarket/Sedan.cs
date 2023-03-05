using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket
{
    internal class Sedan : Car
    {
        public Sedan(double price)
         : base(price)
        {
            GetFuelConsumption(6, 10);
        }
    }
}
