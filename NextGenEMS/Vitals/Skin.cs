using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextGenEMS.Vitals
{
    public class Skin
    {
        [DataMember]
        public VitalsEnums.MeasurementTime MeasurementTime { get; set; }

        [DataMember]
        public VitalsEnums.PulseQuality PulseQuality { get; set; }

        [DataMember]
        public VitalsEnums.PulseQuality PulsePoint { get; set; }
    }
}
