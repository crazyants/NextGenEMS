using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextGenEMS.Medical
{
    public class Substance
    {
        [DataMember]
        public string CommonName { get; set; }

        [DataMember]
        public string GenericName { get; set; }

        [DataMember]
        public List<string> TradeNames { get; set; }

        [DataMember]
        public List<string> AlternateNames { get; set; }

        [DataMember]
        public string DescriptionBrief { get; set; }

        [DataMember]
        public string DescriptionFull { get; set; }

        [DataMember]
        public List<string> LegalStatus { get; set; }

        [DataMember]
        public string LocalProtocol { get; set; }

        [DataMember]
        public string CurrentPatientDose { get; set; }

        [DataMember]
        public string ReccomendedDosageRanges { get; set; }

        [DataMember]
        public string RecreationalDoseRanges { get; set; }

        [DataMember]
        public string OverdoseTreatmentProtocol { get; set; }

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
