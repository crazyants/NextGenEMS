using System.Runtime.Serialization;

namespace NextGenEMS.Vitals
{
    public class BloodGlucose
    {
        [DataMember]
        public int Value { get; set; }

        [DataMember]
        public VitalsEnums.BloodGlucoseReadingLocation BpReadingMethod { get; set; }
    }
}
