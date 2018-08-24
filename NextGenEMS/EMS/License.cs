using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextGenEMS.EMS
{
    public class License
    {
        [DataMember]
        public string LicenseNumber;

        [DataMember]
        public string LegalName;

        [DataMember]
        public EmsEnums.LicenseClassification Classification;

        [DataMember]
        public EmsEnums.LicenseStatus Status;

        [DataMember]
        public string TrainingCenter;

        [DataMember]
        public DateTime RenewalDate;

        [DataMember]
        public DateTime DateLastVerfied;
    }
}
