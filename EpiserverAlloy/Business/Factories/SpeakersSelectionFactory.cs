using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverAlloy.Business.Factories
{
    public class SpeakersSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var speakers = new List<SelectItem>();

            speakers.Add(new SelectItem() { Text = "Scott Allen", Value = "Scott-Allen" });
            speakers.Add(new SelectItem() { Text = "Damien Edwards", Value = "Damien-Edwards" });
            speakers.Add(new SelectItem() { Text = "David Fowler", Value = "David-Fowler" });
            speakers.Add(new SelectItem() { Text = "Scott Guthrie", Value = "Scott-Guthrie" });

            return speakers;
        }
    }
}