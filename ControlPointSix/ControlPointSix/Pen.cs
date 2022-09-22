using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPointSix
{
    internal class Pen : IForSale
    {
        public int Sale()
        {
            Random random = new Random();
            int penPrice = random.Next(3, 5);
            return penPrice;
        }
    }
}
