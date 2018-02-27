using System;
using Concepts;
using doLittle.Events;

namespace Events.DataCollector
{
    public class DataCollectorAdded : IEvent
    {
        public Guid DataCollectorId { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public int YearOfBirth { get; set; }
        public int Sex { get; set; }
        public Guid NationalSociety { get; set; }
        public int PreferredLanguage { get; set; }
        public double LocationLongitude { get; set; }
        public double LocationLatitude { get; set; }
        public DateTimeOffset RegisteredAt { get; set; }
    }
}