using System;
using System.Collections.Generic;
using System.Text;

namespace part_01.ShippingCalc
{
    public class UPS : CalculateWeight
    {
        public decimal CalculateWeight(decimal weight)
        {
            return weight * 20m;
        }
    }
}
