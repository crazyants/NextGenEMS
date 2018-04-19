using System.Runtime.Serialization;

namespace NextGenEMS.Vitals
{
    [DataContract]
    public class Respirations
    {
        [DataMember]
        public int RespirationRate { get; set; }

        [DataMember]
        public VitalsEnums.RespEffort RespEffort { get; set; }

        [DataMember]
        public VitalsEnums.RespEffort RespSounds { get; set; }

        [DataMember]
        public VitalsEnums.RespEffort RespObervationMethod { get; set; }
    }
}
