using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextGenEMS.Vitals
{
    public class Pupils
    {
        [DataMember]
        public VitalsEnums.Pupils Type { get; set; }

        [DataMember]
        public string Notes { get; set; }

    }
}
