using System.Runtime.Serialization;

namespace NextGenEMS.Vitals
{
    [DataContract]
    public class Gcs
    {
        [DataMember]
        public int MotorScore { get; set; }

        [DataMember]
        public int VisualScore { get; set; }

        [DataMember]
        public int VerbalScore { get; set; }

        [DataMember]
        public int TotalScore { get; set; }

        [DataMember]
        public string Notes { get; set; }
    }
}
