using EPiServer.Validation;
using EpiserverAlloy.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverAlloy.Business.Validation
{
    public class EventPageValidator : IValidate<EventPage>
    {
        public IEnumerable<ValidationError> Validate(EventPage instance)
        {
            if (instance.StartDate > instance.EndDate)
            {
                yield return new ValidationError
                {
                    ErrorMessage = "End date has to be older than Start date",
                    Severity = ValidationErrorSeverity.Error
                };
            }
            yield break;
        }
    }
}