using System.Runtime.Serialization;

namespace NextGenEMS.Demographics
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public string Country;

        [DataMember]
        public string Street;

        [DataMember]
        public string UnitNumber;

        [DataMember]
        public string State;

        [DataMember]
        public string ZipCode;
    }
}
