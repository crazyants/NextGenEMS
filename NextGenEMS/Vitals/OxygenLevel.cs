using System.Runtime.Serialization;

namespace NextGenEMS.Vitals
{
    [DataContract]
    public class OxygenLevel
    {
        [DataMember]
        public int OxygenPercent { get; set; }

        [DataMember]
        public VitalsEnums.OxygenReadingMethod OxygenReadingMethod { get; set; }
    }
}
