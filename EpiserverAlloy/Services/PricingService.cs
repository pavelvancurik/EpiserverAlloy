using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverAlloy.Services
{
    public class PricingService
    {
        private const double ONLINE_DISCOUNT = 1.5;

        public double? GetInidividualPrice(double CataloguePrice, int percentOrganizationalDiscount, bool loggedUser, bool OnlineDiscount, int? maxDiscount)
        {
            double price = 0;

            if (!loggedUser)
            {
                return null;
            }

            price = CataloguePrice - GetPercentPrice(CataloguePrice) * percentOrganizationalDiscount;

            if (OnlineDiscount)
            {
                price = price - GetPercentPrice(CataloguePrice) * ONLINE_DISCOUNT;
            }

            if (maxDiscount > 0)
            {
                double maxDiscountedPrice = price - GetPercentPrice(CataloguePrice) * (double)maxDiscount;
                if (price < maxDiscountedPrice)
                {
                    price = maxDiscountedPrice;
                }
            }

            return price;
        }

        private double GetPercentPrice(double price)
        {
            return price / 100;
        }
    }
}