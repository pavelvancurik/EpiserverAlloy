using System.Collections.Generic;
using System.Web.UI;
using EPiServer.Core;
using EPiServer.Events.Clients;
using EpiserverAlloy.Models.Pages;

namespace EpiserverAlloy.Models.ViewModels
{
    public class EventListingViewModel : PageViewModel<EventListingPage>
    {
        public EventListingViewModel(EventListingPage currentPage)
            : base(currentPage)
        {
        }

        public IEnumerable<EventPage> AllEvents { get; set; }
    }
}
