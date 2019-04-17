using EPiServer.Shell.ObjectEditing;
using EpiserverAlloy.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverAlloy.Business.Factories
{
    public class StatusSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var statuses = new List<SelectItem>();

            //todo use adding in For loop
            statuses.Add(new SelectItem() { Text = EventStatus.Unknown.ToString(), Value = EventStatus.Unknown });
            statuses.Add(new SelectItem() { Text = EventStatus.Closed.ToString(), Value = EventStatus.Closed });

            return statuses;
        }


    }
}