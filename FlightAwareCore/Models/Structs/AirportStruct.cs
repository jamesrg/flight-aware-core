using System.Runtime.Serialization;

namespace FlightAware.Models
{
    [DataContract]
    public class AirportStruct
    {
        [DataMember(Name="airport_code")]
        public string AirportCode { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "elevation")]
        public float Elevation { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "longitude")]
        public double Longitude { get; set; }

        [DataMember(Name = "latitude")]
        public double Latitude { get; set; }

        [DataMember(Name = "timezone")]
        public string Timezone { get; set; }
        
        [DataMember(Name="country_code")]
        public string CountryCode { get; set; }

        [DataMember(Name="wiki_url")]
        public string WikiUrl { get; set; }

        [DataMember(Name="alternate_ident")]
        public string AlternateIdent { get; set; }
    }
}