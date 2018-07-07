using System.Runtime.Serialization;
using NextGenEMS.Backend.HelperClasses;

namespace NextGenEMS.Vitals
{
    [DataContract]
    public class Vitals
    {
        public Vitals()
        {
            // Initalize all objects
            Timestamp = new Timestamp();
            BloodPressure = new BloodPressure();
            Pulse = new Pulse();
            OxygenLevel = new OxygenLevel();
            Respirations = new Respirations();
            Temperature = new Temperature();
        }

        [DataMember]
        public Timestamp Timestamp { get; set; }

        [DataMember]
        public BloodPressure BloodPressure { get; set; }

        [DataMember]
        public BloodGlucose BloodGlucose { get; set; }

        [DataMember]
        public Pulse Pulse { get; set; }


        [DataMember]
        public OxygenLevel OxygenLevel { get; set; }

        [DataMember]
        public Respirations Respirations { get; set; }

        [DataMember]
        public VitalsEnums.LocClassification Loc { get; set; }

        [DataMember]
        public Temperature Temperature { get; set; }
    }
}
