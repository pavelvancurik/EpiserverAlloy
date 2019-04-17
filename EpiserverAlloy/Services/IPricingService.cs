using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiserverAlloy.Services
{
    public interface IPricingService
    {
        double? GetInidividualPrice(double CataloguePrice, int percentOrganizationalDiscount, bool loggedUser, bool OnlineDiscount, int? maxDiscount);
    }
}
