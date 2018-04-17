using NextGenEMS.Classes;

namespace NextGenEMS.Vitals
{
    public class Vitals
    {
        public Timestamp Timestamp { get; set; }

        public BloodPressure BloodPressure { get; set; }

        public Pulse Pulse { get; set; }

        public OxygenLevel OxygenLevel { get; set; }

        public Respirations Respirations { get; set; }

        public Loc LevelOfConsciousness { get; set; }        public Temperature Temperature { get; set; }       public string VitalsNotes { get; set; }
    }
}
