// ReSharper disable InconsistentNaming

namespace NextGenEMS.EMS
{
    public class EmsEnums
    {
        public enum LicenseClassification
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

        public enum ProviderRole
        {
            Lead,
            Assistant,
            Volunteer
        }
    }
}
