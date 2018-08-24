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
            BloodGlucose = new BloodGlucose();
            Skin = new Skin();
            Pupils = new Pupils();
            Gcs = new Gcs();
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
        public Skin Skin { get; set; }

        [DataMember]
        public Pupils Pupils { get; set; }

        [DataMember]
        public OxygenLevel OxygenLevel { get; set; }

        [DataMember]
        public Respirations Respirations { get; set; }

        [DataMember]
        public VitalsEnums.LocClassification Loc { get; set; }

        [DataMember]
        public Temperature Temperature { get; set; }

        [DataMember]
        public Gcs Gcs { get; set; }

        [DataMember]
        public string Notes { get; set; }
    }
}
