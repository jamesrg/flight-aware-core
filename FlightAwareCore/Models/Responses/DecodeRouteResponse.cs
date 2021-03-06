using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FlightAware.Models
{
    [DataContract]
    public class DecodeRouteResponse
    {
        [DataMember(Name="DecodeRouteResult")]
        public DecodeRouteResult Result { get; set; }
    }

    [DataContract]
    public class DecodeRouteResult
    {
        [DataMember(Name="data")]
        public IEnumerable<FlightRouteStruct> Data { get; set; }
        
        [DataMember(Name="route_distance")]
        public string RouteDistance { get; set; }
    }
}