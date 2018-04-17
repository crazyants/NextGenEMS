namespace NextGenEMS.Vitals
{
    public class BloodPressure
    {
        public int Systolic { get; set; }

        public int Diastolic { get; set; }

        public VitalsEnums.BpReadingMethod BpReadingMethod { get; set; }

        public VitalsEnums.BpReadingMethod BpReadingLocation { get; set; }

        public VitalsEnums.PulseQuality PulseQuality { get; set; }
    }
}
