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
        public VitalsEnums.SkinColor SkinColor { get; set; }

        [DataMember]
        public VitalsEnums.SkinTemp SkinTemp { get; set; }

        [DataMember]
        public VitalsEnums.SkinMoisture SkinMoisture { get; set; }
    }
}
