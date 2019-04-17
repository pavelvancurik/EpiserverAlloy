using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverAlloy.Services
{
    public class PricingService : IPricingService
    {
        private const double ONLINE_DISCOUNT = 1.5;
        private const int MIN_ALLOWED_MAX_DISCOUNT = 0;
        private const int MAX_ALLOWED_MAX_DISCOUNT = 25;

        public double? GetInidividualPrice(double CataloguePrice, int percentOrganizationalDiscount, bool loggedUser, bool OnlineDiscount, int? maxDiscount)
        {
            if (maxDiscount is int && (maxDiscount < MIN_ALLOWED_MAX_DISCOUNT || maxDiscount > MAX_ALLOWED_MAX_DISCOUNT))
            {
                throw new ArgumentException("Max discount is out of range.");
            }

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

            if (maxDiscount is int)
            {
                double maxDiscountedPrice = CataloguePrice - GetPercentPrice(CataloguePrice) * (double)maxDiscount;
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