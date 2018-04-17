namespace NextGenEMS.Vitals
{
    public class Pulse
    {
        public int PulseRate;

        public VitalsEnums.MeasurementTime MeasurementTime { get; set; }

        public VitalsEnums.PulseQuality PulseQuality { get; set; }

        public VitalsEnums.PulseQuality PulsePoint { get; set; }
    }
}
