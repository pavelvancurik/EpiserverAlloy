using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverAlloy.Models.Pages
{
    [ContentType(DisplayName = "EventListingPage", GUID = "f9908daf-b579-45c4-900e-7dcdfe71ffb3", Description = "Event listing page for exercise")]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(EventPage) }) // Pages we can create under EventListingPage
    ]
    public class EventListingPage : SitePageData
    {

    }
}