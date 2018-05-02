using System.Runtime.Serialization;

namespace NextGenEMS.Demographics
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string UnitNumber { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string ZipCode { get; set; }
    }
}
