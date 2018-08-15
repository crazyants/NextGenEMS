using System.Runtime.Serialization;

namespace NextGenEMS.Vitals
{
    public class Opqrst
    {
        [DataMember]
        public string Onset { get; set; }

        [DataMember]
        public string Provocation { get; set; }

        [DataMember]
        public string QualityOfPain { get; set; }

        [DataMember]
        public string RegionAndRadiation { get; set; }

        [DataMember]
        public string Severity { get; set; }

        [DataMember]
        public string TimeSinceOnset { get; set; }

        [DataMember]
        public string ClarifyingQuestions { get; set; }
    }
}
