using System.Runtime.Serialization;

namespace NextGenEMS.Vitals
{
    [DataContract]
    public class BloodPressure
    {
        [DataMember]
        public int Systolic { get; set; }

        [DataMember]
        public int Diastolic { get; set; }

        [DataMember]
        public VitalsEnums.BpReadingMethod BpReadingMethod { get; set; }

        [DataMember]
        public VitalsEnums.BpReadingMethod BpReadingLocation { get; set; }

        [DataMember]
        public VitalsEnums.PulseQuality PulseQuality { get; set; }
    }
}
