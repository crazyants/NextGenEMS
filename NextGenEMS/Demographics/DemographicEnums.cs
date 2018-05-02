using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGenEMS.Demographics
{
    public class DemographicEnums
    {
        public enum Gender
        {
            Male, 
            Female,
            Refused,
            NonBinary
        }

        public enum Race
        {
            White, 
            Hispanic,
            AsianPacificIslander,
            Black,
            AmericanIndian,
            Other
        }
    }
}
