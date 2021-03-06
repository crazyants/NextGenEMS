﻿namespace NextGenEMS.Vitals
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
            AlertOrientedX4,
            AlertOrientedX3,
            AlertOrientedX2,
            AlertOrientedX1,
            Verbal,
            Pain,
            Unresponsive
        }

        #endregion

        #region Temperature

        public enum TemperatureUnits
        {
            Degrees,
            Celcius
        }

        public enum TemperatureLocation
        {
            LeftEar,
            RightEar,
            Rectum,
            Oral,
            Axillary,
            Temporal
        }

        #endregion

        #region Skin

        public enum SkinTemp
        {
            Cold,
            Cool,
            Normal,
            Warm,
            Hot
        }

        public enum SkinColor
        {
            Pink,
            Normal,
            Grey,
            BlueTint,
            Pale,
        }

        public enum SkinMoisture
        {
            Dry,
            Normal,
            Moist,
            Clammy,
            Wet,
            Sweating
        }

        #endregion

        public enum BloodGlucoseReadingLocation
        {
            LeftHand,
            RightHand
        }

        public enum Pupils
        {
            Dialated,
            Constricted,
            Unequal,
            DelayedTracking,
            NoTracking,
            Bloodshot,
            EyeDamage,
            Perrl,
        }

        /// <summary>
        /// NOTE: Taken directly from the Wisc Ambluence Run Template
        /// </summary>
        public enum CauseOfInjury
        {
            AthleticInjury,
            BicycleCrash,
            Bite,
            ChemicalExposure,
            ChildBatteringSuspected,
            Drowning,
            DrugIngestion,
            Electrocution,
            ExcessiveCold,
            ExcessiveHeat,
            Fall,
            FireFlames,
            FirearmSelfInflicted,
            FirearmAccidental,
            FirearmAssault,
            Lightning,
            MachineryInjury,
            MechanicalSuffocation,
            MotorVehicleNonTraffic,
            MotorVehicleTraffic,
            PedestrianTraffic,
            PhysicalAssault,
            PoisonNotDrugs,
            RadiationExposure,
            SexualAssault,
            SmokeInhalation,
            Stabbing,
            StingsPlantAnimal,
            WaterTransportIncident,
            Unknown,
            Other
        }

        public enum ProviderImpression
        {
            AbdPnProblems,
            AirwayObstruction,
            AllergicReaction,
            AlteredLoc,
            BehavioralPsych,
            CardiacArrest,
            CardiacRythemDisturb,
            ChestPainDiscomfort,
            CongestiveHeartFailure,
            DiabeticSymptoms,
            Electrocution,
            GiBleed,
            Headache,
            Hypertension,
            HyperthermiaFever,
            Hyopthermia,
            HypovolemiaShock,
            IntoxicationSuspected,
            ObviousDeath,
            PoisonDrugInjection,
            PregnancyObDelivery,
            RespiratoryArrest,
            RespiratoryDistress,
            Seizure,
            SexualAssault,
            ToxicInhalation,
            StingsBites,
            Stroke,
            SyncopeFainting,
            TruamaticInjury,
            VaginalHemorrhage,
            Unknown,
            Other
        }
    }
}

