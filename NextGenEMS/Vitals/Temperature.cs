using System.Runtime.Serialization;

namespace NextGenEMS.Vitals
{
    [DataContract]
    public class Temperature
    {
        [DataMember]
        public int ReadingValue { get; set; }

        [DataMember]
        public VitalsEnums.TemperatureUnits Units { get; set; }

        [DataMember]
        public VitalsEnums.TemperatureLocation Location { get; set; }
    }
}
