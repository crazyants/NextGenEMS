// ReSharper disable InconsistentNaming

namespace NextGenEMS.EMS
{
    public class EmsEnums
    {
        public enum LicenseType
        {
            CPR,
            EMR,
            EMT,
            AEMT,
            Paramedic,
            Nurse
        }

        public enum LicenseStatus
        {
            Active,
            Lapsed,
            Revoked
        }
    }
}
