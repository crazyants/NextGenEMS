using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using NextGenEMS.Demographics;

namespace NextGenEMS.People
{
    public class Provider
    {
        [DataMember]
        public string ProviderOrgnizationId { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        public Address HomeAddress;

        [DataMember]
        public DemographicEnums.Gender Gender { get; set; }

        [DataMember]
        public string DateOfBirth { get; set; }

        [DataMember]
        public string Age { get; set; }

        [DataMember]
        public string Weight { get; set; }

        [DataMember]
        public ContactInfo PatientEmergencyContactInfo { get; set; }
    }
}
