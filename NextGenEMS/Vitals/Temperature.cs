using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGenEMS.Vitals
{
    public class Temperature
    {
        public int ReadingValue { get; set; }

        public VitalsEnums.TemperatureUnits Units { get; set; }

        public VitalsEnums.TemperatureLocation Location { get; set; }
    }
}
