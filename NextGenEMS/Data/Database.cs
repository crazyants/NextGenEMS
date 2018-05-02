using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using NextGenEMS.Backend;
using NextGenEMS.People;

namespace NextGenEMS.Data
{
    [DataContract]
    public class Database
    {
        public static void Initalize()
        {
            PatientList = new List<Patient>();
        }

        [DataMember]
        public static List<Patient> PatientList;

        [DataMember]
        public static Preferences CurrentPreferences;
    }
}
