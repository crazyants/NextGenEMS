using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NextGenEMS.Classes
{
    [DataContract]
    public class Patient
    {

        #region Patient Demographic Info

        /// <summary>
        //    <name>EMS Patient ID</name>
        //    <national>No</national>
        //    <state>No</state>
        //    <definition>The unique ID for the patient within the Agency</definition>
        //    <usage>Optional</usage>
        /// </summary>
        [DataMember]
        public string PatientId;

        /// <summary>
        // <number>ePatient.02</number>
        // <name>Last Name</name>
        // <national>No</national>
        // <state>Yes</state>
        // <definition>The patient's last (family) name</definition>
        // <v2Number>E06_01</v2Number>
        // <usage>Recommended</usage>
        // <comment>Pertinent negatives accepted with option of "Unable to Complete" or "Refused".</comment>
        // <PNNil>Yes</PNNil>
        /// </summary>
        [DataMember]
        public string LastName;

        /// <summary>
        //        <number>ePatient.03</number>
        //        <name>First Name</name>
        //        <national>No</national>
        //        <state>Yes</state>
        //        <definition>The patient's first (given) name</definition>
        //        <v2Number>E06_02</v2Number>
        //        <usage>Recommended</usage>
        //        <comment>Pertinent negatives accepted with option of "Unable to Complete" or "Refused".</comment>
        //        <PNNil>Yes</PNNil>
        /// </summary>
        [DataMember]
        public string FirstName;

        /// <summary>
        //        <number>ePatient.04</number>
        //        <name>Middle Initial/Name</name>
        //        <national>No</national>
        //        <state>No</state>
        //        <definition>The patient's middle name, if any</definition>
        //        <v2Number>E06_03</v2Number>
        //        <usage>Optional</usage>
        /// </summary>
        [DataMember]
        public string MiddleName;

        [DataMember]
        public Address PatientHomeAddress;

        /// <summary>
        //        <number>ePatient.13</number>
        //        <name>Gender</name>
        //        <national>Yes</national>
        //        <state>Yes</state>
        //        <definition>The Patient's Gender</definition>
        //        <v2Number>E06_11</v2Number>
        //        <usage>Required</usage>
        /// </summary>
        [DataMember]
        public string Gender;

        /// <summary>
        //        <number>ePatient.14</number>
        //        <name>Race</name>
        //        <national>Yes</national>
        //        <state>Yes</state>
        //        <definition>The patient's race as defined by the OMB (US Office of Management and Budget)</definition>
        //        <v2Number>E06_12</v2Number>
        //        <usage>Required</usage>
        /// </summary>
        [DataMember]
        public string Race;

        /// <summary>
        //        <number>ePatient.17</number>
        //        <name>Date of Birth</name>
        //        <national>No</national>
        //        <state>Yes</state>
        //        <definition>The patient's date of birth</definition>
        //        <v2Number>E06_16</v2Number>
        //        <usage>Recommended</usage>
        //        <PNNil>Yes</PNNil>
        /// </summary>
        [DataMember]
        public string DateOfBirth;

        /// <summary>
        //        <number>ePatient.15</number>
        //        <name>Age</name>
        //        <national>Yes</national>
        //        <state>Yes</state>
        //        <definition>The patient's age (either calculated from date of birth or best approximation)</definition>
        //        <v2Number>E06_14</v2Number>
        //        <usage>Required</usage>
        /// </summary>
        [DataMember]
        public string Age;

        [DataMember]
        public ContactInfo PatientContactInfo;

        [DataMember]
        public ContactInfo PatientEmergencyContactInfo;

        #endregion

        #region  SAMPLE Info

        public string SignsAndSymptoms;

        [DataMember]
        public List<Allergin> Allergies;

        [DataMember]
        public List<Medication> CurrentMedications;

        [DataMember]
        public List<Illness> PastIllnesses;

        [DataMember]
        public string LastOralIntake;

        [DataMember]
        public string Events;

        #endregion

        #region OPQRST Info

        [DataMember]
        public string Onset;

        [DataMember]
        public string Provocation;

        [DataMember]
        public string QualityOfPain;

        [DataMember]
        public string RegionAndRadiation;

        [DataMember]
        public string Severity;

        [DataMember]
        public string TimeSinceOnset;

        #endregion

        public List<Vitals> VitalsReadings;
    }
}
