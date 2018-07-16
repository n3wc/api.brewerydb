using System;

namespace api.brewerydb.Models
{
    public class Location
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string ExtendedAddress { get; set; }
        public string Locality { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string HoursOfOperation { get; set; }
        public string HoursOfOperationExplicit { get; set; }
        public string HoursOfOperationNotes { get; set; }
        public string TourInfo { get; set; }
        public string TimezoneId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string IsPrimary { get; set; }
        public string InPlanning { get; set; }
        public string IsClosed { get; set; }
        public string OpenToPublic { get; set; }
        public string LocationType { get; set; }
        public string LocationTypeDisplay { get; set; }
        public string CountryIsoCode { get; set; }
        public string Status { get; set; }
        public string StatusDisplay { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Country Country { get; set; }
        public int? yearOpened { get; set; }
        public int? breweryId { get; set; }
        public string brewery { get; set; }
    }
}
