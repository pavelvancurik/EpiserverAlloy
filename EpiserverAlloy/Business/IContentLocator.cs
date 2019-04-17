using EPiServer.Core;
using EpiserverAlloy.Models.Pages;
using EpiserverAlloy.Models.ViewModels;
using System.Collections.Generic;

namespace EpiserverAlloy.Business
{
    public interface IContentLocator
    {
        IEnumerable<T> GetAll<T>(ContentReference rootLink) where T : PageData;

        IEnumerable<PageData> FindPagesByPageType(PageReference pageLink, bool recursive, int pageTypeId);

        IEnumerable<ContactPage> GetContactPages();

        IEnumerable<EventPage> GetEventPages(ContentReference parent);
    }
}
