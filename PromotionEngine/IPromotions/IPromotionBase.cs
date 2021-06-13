using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.IPromotions
{
    public interface IPromotionBase
    {
        int MaximumPossibleRepeationsForTheCart(Cart cart);
        double TotalDiscount(int MaxPossibleRepetitions);
    }
}
