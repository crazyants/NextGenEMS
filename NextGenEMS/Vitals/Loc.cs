using System.Runtime.Serialization;

namespace NextGenEMS.Vitals
{
    [DataContract]
    public class Loc
    {
        [DataMember]
        public VitalsEnums.LocClassification LocClassification { get; set; }

        [DataMember]
        public int AlertScore { get; set; }

        [DataMember]
        public string AlertnessNotes{ get; set; }
    }
}
