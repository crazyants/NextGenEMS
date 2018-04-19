using System.Runtime.Serialization;
using NextGenEMS.Classes;

namespace NextGenEMS.Vitals
{
    [DataContract]
    public class Vitals
    {
        [DataMember]
        public Timestamp Timestamp { get; set; }

        [DataMember]
        public BloodPressure BloodPressure { get; set; }

        [DataMember]
        public Pulse Pulse { get; set; }

        [DataMember]
        public OxygenLevel OxygenLevel { get; set; }

        [DataMember]
        public Respirations Respirations { get; set; }

        [DataMember]
        public Loc LevelOfConsciousness { get; set; }

        [DataMember]
        public Temperature Temperature { get; set; }

        [DataMember]
        public string VitalsNotes { get; set; }
    }
}
