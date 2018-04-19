using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGenEMS.Vitals
{
    public class VitalsEnums
    {

        #region  Pulse

        public enum PulseQuality
        {
            Regular,
            Irregular
        };

        public enum PulsePoint
        {
            Radial,
            Temporal,
            Carotid,
            Brachial,
            Apical,
            Femoral,

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
            Normal,
            Labored,
            Shallow,
            Absent,
            Assited
        };

        public enum RespSounds
        {
            Wheezing,
            Stridor,
            InspiratoryGasp,
            Crackles
        };

        public enum RespObervationMethod
        {
            Ear,
            Stethoscope,
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

        #region O2 Readings

        public enum OxygenReadingMethod
        {
            Fingertip,
            Earlobe
        }

        #endregion

        #region Level Of Consciousness

        public enum LocClassification
        {
            Alert,
            Verbal,
            Pain,
            Unresponsive
        }

        #endregion
    }
}
