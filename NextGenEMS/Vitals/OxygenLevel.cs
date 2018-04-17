using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGenEMS.Vitals
{
    public class OxygenLevel
    {
        public int OxygenPercent { get; set; }

        public VitalsEnums.OxygenReadingMethod OxygenReadingMethod { get; set; }
    }
}
