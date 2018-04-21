using System.Runtime.Serialization;

namespace NextGenEMS.Vitals
{
    [DataContract]
    public class Pulse
    {
        [DataMember]
        public int PulseRate { get; set; }

        [DataMember]
        public VitalsEnums.MeasurementTime MeasurementTime { get; set; }

        [DataMember]
        public VitalsEnums.PulseQuality PulseQuality { get; set; }

        [DataMember]
        public VitalsEnums.PulseQuality PulsePoint { get; set; }
    }
}
