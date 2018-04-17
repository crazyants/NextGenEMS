using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGenEMS.Vitals
{
    public class VitalsEnums
    {

        #region  General

        public enum PulseQuality
        {
            Regular,
            Irregular
        };

        public enum MeasurementTime
        {
            FifteenSeconds,
            ThirtySeconds,
            OneMinute
        };

        #endregion

        #region Respirations


        public enum RespEffort
        {
            Temp
        };

        #endregion

        #region Blood Pressure

        public enum BpReadingMethod
        {
            Manual, 
            Automated
        }

        public enum BpReadingLocation
        {
            LeftForearm, 
            RightForearm,
            LeftWrist,
            RightWrist
        }

        # endregion 
    }
}
