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
        //•	Wire it all up together in the Event Listing Page controller
        //o   Add a constructor with a parameter of IContentLocator to the controller and set an internal property to its value
        //o Create a new view model of EventListingViewModel in the Index method
        //o   Set the model’s All Events property by calling the ContentLocator GetEventPages method
        //o Return the view with the model

        private IContentLocator myLocator;

        public EventListingPageController(IContentLocator locator)
        {
            myLocator = locator;
        }

        public ActionResult Index(EventListingPage currentPage)
        {
            var model = new EventListingViewModel(currentPage)
            {
                AllEvents = myLocator.GetEventPages(currentPage.ContentLink)
            };

            return View(model);
        }
    }
}
