using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NextGenEMS.Medical
{
    [DataContract]
    public class Condition
    {
        [DataMember]
        public bool Existing { get; set; }

        [DataMember]
        public string CommonName { get; set; }

        [DataMember]
        public List<string> AlternateNames { get; set; }

        [DataMember]
        public string BriefDescription { get; set; }

        [DataMember]
        public string FullDescription { get; set; }
    }
}
