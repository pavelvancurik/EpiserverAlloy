using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using EpiserverAlloy.Business.Factories;

namespace EpiserverAlloy.Models.Pages
{
    [ContentType(DisplayName = "EventPage", GUID = "35e71f4b-4d9a-44fe-b43a-7f8579a0ba19", Description = "Event page type for exercise")]
    public class EventPage : StandardPage
    {
        [Display(
            Name = "Summary",
            GroupName = SystemTabNames.Content)]
        [UIHint(UIHint.Textarea)]
        public virtual String Summary { get; set; }

        [Display(
            Name = "Description",
            GroupName = SystemTabNames.Content)]
        public virtual XhtmlString Description { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z0-9 ]+")]
        [Display(
            Name = "Title",
            GroupName = "Event")]
        public virtual String Title { get; set; }

        [Required]
        [SelectOne(SelectionFactoryType = typeof(SpeakersSelectionFactory))]
        [Display(
            Name = "Speaker",
            GroupName = "Event")]
        public virtual String Speaker { get; set; }

        [Range(1, 100)]
        [Display(
            Name = "Number of attendees",
            GroupName = "Event")]
        public virtual int NoAttendees { get; set; }

        [Required]
        [Display(
            Name = "Start date",
            GroupName = "Event")]
        public virtual DateTime StartDate { get; set; }

        [Display(
            Name = "End date",
            GroupName = "Event")]
        public virtual DateTime EndDate { get; set; }

        [Display(
            Name = "Event image",
            GroupName = "Event")]
        [UIHint(UIHint.Image)]
        public virtual ContentReference EventImage { get; set; }

        [Display(
            Name = "Additional content",
            GroupName = SystemTabNames.Content)]
        public virtual ContentArea AdditionalContent { get; set; }

        [BackingType(typeof(PropertyNumber))]
        [Display(
            Name = "Status",
            GroupName = "Event")]
        [SelectOne(SelectionFactoryType = typeof(StatusSelectionFactory))]
        public virtual EventStatus EventStatus { get; set; }
    }

    public enum EventStatus
    {
        Unknown = 0,
        Closed = 1
    }
}