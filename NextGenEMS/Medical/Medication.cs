using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NextGenEMS.Medical
{
    [DataContract]
    public class Medication
    {
        [DataMember]
        public string CommonName { get; set; }

        [DataMember]
        public string GenericName { get; set; }

        [DataMember]
        public List<string> TradeNames { get; set; }

        [DataMember]
        public string DescriptionBrief { get; set; }

        [DataMember]
        public string DescriptionFull { get; set; }

        [DataMember]
        public string LocalProtocol { get; set; }

        [DataMember]
        public string CurrentPatientDose { get; set; }

        [DataMember]
        public string ReccomendedDosageRanges { get; set; }

        [DataMember]
        public string DurationTaken { get; set; }

        [DataMember]
        public string PatientNotes { get; set; }

        [DataMember]
        public List<MedicalEnums.SideEffect> SideEffects { get; set; }

        [DataMember]
        public List<Medication> DangerousInteractions { get; set; }
    }
}
