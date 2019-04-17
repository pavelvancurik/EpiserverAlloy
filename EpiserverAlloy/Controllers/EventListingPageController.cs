using System.Web.Mvc;
using EpiserverAlloy.Models.Pages;
using EpiserverAlloy.Models.ViewModels;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EpiserverAlloy.Business;

namespace EpiserverAlloy.Controllers
{
    public class EventListingPageController : PageControllerBase<EventListingPage>
    {
        private IContentLocator internalLocator;

        public EventListingPageController(IContentLocator locator)
        {
            internalLocator = locator;
        }

        public ActionResult Index(EventListingPage currentPage)
        {
            var model = new EventListingViewModel(currentPage)
            {
                AllEvents = internalLocator.GetEventPages(currentPage.ContentLink)
            };

            return View(model);
        }
    }
}
