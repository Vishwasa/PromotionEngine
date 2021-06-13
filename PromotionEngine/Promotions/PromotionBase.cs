using PromotionEngine.IPromotions;
using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public abstract class PromotionBase : IPromotionBase
    {
        Dictionary<string, int> ProductMinQtyMappingForEligibility = new Dictionary<string, int>();
        double DiscountPrice;
        public bool IsActive { get; set; }
        public abstract bool IsValidForThisCart(Cart cart);
        public abstract int MaximumPossibleRepeationsForTheCart(Cart cart);
        public double TotalDiscount(int _possibleRepetitions)
        {
            return DiscountPrice * _possibleRepetitions;
        }
    }
}
