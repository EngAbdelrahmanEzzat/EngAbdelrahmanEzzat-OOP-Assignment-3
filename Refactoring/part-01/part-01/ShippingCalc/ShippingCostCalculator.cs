using System;
using System.Collections.Generic;
using System.Text;

namespace part_01.ShippingCalc
{
    public interface CalculateWeight
    {
        decimal CalculateWeight(decimal weight);


    }
    public class Aramex : CalculateWeight
    {
        public decimal CalculateWeight(decimal weight)
        {
            return weight * 12m;
        }
    }
    public class FedEx : CalculateWeight
    {
        public decimal CalculateWeight(decimal weight)
        {
            return weight * 15m;
        }

    }
    public class DHL : CalculateWeight
    {
        public decimal CalculateWeight(decimal weight)
        {
            return weight * 18m;
        }
    }
    public class ShippingCostCalculator
    {
        private readonly CalculateWeight _calculateWeight;


        public ShippingCostCalculator(CalculateWeight calculateWeight)
        {
            _calculateWeight = calculateWeight;
        }
        public decimal Calculate(decimal weightKg)
        {
            return _calculateWeight.CalculateWeight(weightKg);
        }
    }


}
