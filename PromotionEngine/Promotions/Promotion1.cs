using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    class Promotion1 : PromotionBase
    {
        Cart cart;
        Promotion1(Cart _cart)
        {
            cart = _cart;
        }
         Dictionary<string, int> ProductMinQtyMappingForEligibility = new Dictionary<string, int>()
            {
                { "A", 3}
            };
        //Dictionary<string, int> _productMinQtyMappingForEligibility = ProductMinQtyMappingForEligibility, double _discountPrice = 120) : base(_productMinQtyMappingForEligibility, _discountPrice)
        

        public override bool IsValidForThisCart(Cart cart)
        {
            //ProductMinQtyMappingForEligibility.Select(i=>i.Key!=get)
            foreach (var item in ProductMinQtyMappingForEligibility)
            {
                var count = getItemsCountFromCartByName(cart, item.Key);
                if (count == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public override int MaximumPossibleRepeationsForTheCart(Cart cart)
        {
            if (!IsValidForThisCart(cart))
            {
                return 0;
            }
            else
            {
                var ItemsOfTypeA = getItemsCountFromCartByName(cart, "A");
                return ItemsOfTypeA / ProductMinQtyMappingForEligibility["A"];
            }
        }

        private int getItemsCountFromCartByName(Cart cart, string productNameForPromo)
        {
            //cart.
            cart.
            return 0;
        }
    }
}
