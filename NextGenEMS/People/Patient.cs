using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using NextGenEMS.Demographics;
using NextGenEMS.Medical;
using NextGenEMS.Vitals;

namespace NextGenEMS.People
{
    [DataContract]
    public class Patient
    {
        // Simple constructor
        public Patient()
        {
            // Initalize lists
            Allergies = new List<Allergin>();
            CurrentMedications = new List<Medication>();
            PastIllnesses = new List<Illness>();
            VitalsReadings = new List<Vitals.Vitals>();

            // Initalize Objects
            PatientHomeAddress = new Address();
            PatientContactInfo = new ContactInfo();
            PatientEmergencyContactInfo = new ContactInfo();
        }

        [DataMember]
        public List<Vitals.Vitals> VitalsReadings { get; set; }

        #region Patient Demographic Info

        /// <summary>
        //    <name>EMS Patient ID</name>
        //    <national>No</national>
        //    <state>No</state>
        //    <definition>The unique ID for the patient within the Agency</definition>
        //    <usage>Optional</usage>
        /// </summary>
        [DataMember]
        public string PatientId { get; set; }

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
        public string LastName { get; set; }

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
        public string FirstName { get; set; }

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
        public string MiddleName { get; set; }

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
        public DemographicEnums.Gender Gender { get; set; }

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
        public DemographicEnums.Race Race { get; set; }

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
        public string DateOfBirth { get; set; }

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
        public string Age { get; set; }

        [DataMember]
        public string Weight { get; set; }

        [DataMember]
        public ContactInfo PatientContactInfo { get; set; }

        [DataMember]
        public ContactInfo PatientEmergencyContactInfo { get; set; }

        #endregion

        #region  SAMPLE Info

        public string SignsAndSymptoms { get; set; }

        [DataMember]
        public List<Allergin> Allergies { get; set; }

        [DataMember]
        public List<Medication> CurrentMedications { get; set; }

        [DataMember]
        public List<Illness> PastIllnesses { get; set; }

        [DataMember]
        public string LastOralIntake { get; set; }

        [DataMember]
        public string Events { get; set; }

        [DataMember]
        public string SampleClarifyingQuestions { get; set; }

        #endregion

        #region  Additional Patient Assessment info

        [DataMember]
        public Opqrst Opqrst { get; set; }

        [DataMember]
        public bool MoiOrNoi { get; set; }

        [DataMember]
        public string MoiNoiDescription { get; set; }

        [DataMember]
        public string ChiefComplaint { get; set; }

        [DataMember]
        public string CauseOfInjury { get; set; }

        [DataMember]
        public string ProviderImpression { get; set; }
        

        #endregion 

        

        
    }
}
