using NextGenEMS.Backend;
using NextGenEMS.Data;
using NextGenEMS.Demographics;
using NextGenEMS.People;
using NextGenEMS.Vitals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using NextGenEMS.Backend.HelperClasses;
using NextGenEMS.EMS;

namespace NextGenEMS.Frontend
{
    /// <summary>
    /// Interaction logic for PatientInfoEditor.xaml
    /// </summary>
    public partial class PatientInfoEditor : Window
    {
        private static Patient _patient;

        // Standard Constructor accepting a single patient object
        public PatientInfoEditor()
        {
            // Create a new empty patient object
            _patient = new Patient();

            //Initialize window
            InitializeComponent();
            PopulateComboBoxes();
        }

        public void UpdatePatientInfo()
        {
            // Populate patient demographic fields
            FirstNameTextbox.Text = _patient.FirstName;
            LastNameTextbox.Text = _patient.LastName;
            DateOfBirthDatePicker.Text = _patient.DateOfBirth;
            AgeTextbox.Text = _patient.Age;
            StreetAddressTextbox.Text = _patient.PatientHomeAddress.Street;
            StateTextbox.Text = _patient.PatientHomeAddress.State;
            CityTextbox.Text = _patient.PatientHomeAddress.City;
            StreetAddressTextbox.Text = _patient.PatientHomeAddress.ZipCode;
            WeightTextbox.Text = _patient.Weight;
            GenderComboBox.Text = _patient.Gender.ToString();
            RaceComboBox.Text = _patient.Race.ToString();

            // Populate patient vitals timestamps
            if (_patient.VitalsReadings != null)
            {
                foreach (var vitalSet in _patient.VitalsReadings)
                {
                    VitalsTimestampListBox.Items.Add(vitalSet.Timestamp.TimeString);
                }
            }

            // Populate patient vitals fields
            if (VitalsTimestampListBox.Items.Count > 0)
            {
                if (_patient.VitalsReadings != null)
                {
                    var vitalsSet = _patient.VitalsReadings.First();
                    VitalsTimestampListBox.SelectedIndex = 0;
                    PulseRateTextbox.Text = vitalsSet.Pulse.PulseRate.ToString();
                    PulseQualityComboBox.Text = vitalsSet.Pulse.PulseQuality.ToString();
                    BpSystolicTextbox.Text = vitalsSet.BloodPressure.Systolic.ToString();
                    BpDiastolicTextbox.Text = vitalsSet.BloodPressure.Diastolic.ToString();
                    PulseLocationComboBox.Text = vitalsSet.Pulse.PulsePoint.ToString();
                    RespirationsTextbox.Text = vitalsSet.Respirations.RespirationRate.ToString();
                    RespEffortComboBox.Text = vitalsSet.Respirations.RespEffort.ToString();
                    BpLocationComboBox.Text = vitalsSet.BloodPressure.BpReadingLocation.ToString();
                    BodyTempTextbox.Text = vitalsSet.Temperature.ReadingValue.ToString();
                    BodyTempMethodComboBox.Text = vitalsSet.Temperature.Location.ToString();
                    BloodGcTextbox.Text = vitalsSet.BloodGlucose.Value.ToString();
                    GcMethodComboBox.Text = vitalsSet.BloodGlucose.BpReadingMethod.ToString();
                    SP02Textbox.Text = vitalsSet.OxygenLevel.OxygenPercent.ToString();
                    SP02LocationComboBox.Text = vitalsSet.OxygenLevel.OxygenReadingMethod.ToString();
                    SkinFeelComboBox.Text = vitalsSet.Skin.SkinMoisture.ToString();
                    SkinTempComboBox.Text = vitalsSet.Skin.SkinTemp.ToString();
                    LocComboBox.Text = vitalsSet.Loc.ToString();
                    PupilResponseComboBox.Text = vitalsSet.Pupils.Type.ToString();
                    PERRLNotesTextbox.Text = vitalsSet.Pupils.Notes;
                    GcsMotorScoreTextbox.Text = vitalsSet.Gcs.MotorScore.ToString();
                    GcsVerbalScoreTextbox.Text = vitalsSet.Gcs.VerbalScore.ToString();
                    GcsVisualScoreTextbox.Text = vitalsSet.Gcs.VisualScore.ToString();
                    GcsVisualScoreTextbox.Text = vitalsSet.Gcs.TotalScore.ToString();
                    ProviderNotesTextbox.Text = vitalsSet.Notes;
                }
            }

            // Populate OPQRST fields
            OnsetTextbox.Text = _patient.Opqrst.Onset;
            ProvocationTextbox.Text = _patient.Opqrst.Provocation;
            QualityTextbox.Text = _patient.Opqrst.QualityOfPain;
            RadiationTextbox.Text = _patient.Opqrst.RegionAndRadiation;
            SeverityTextbox.Text = _patient.Opqrst.Severity;
            TimeTextbox.Text = _patient.Opqrst.TimeSinceOnset;
            OpqrstClarifyingQuestionsTextbox.Text = _patient.Opqrst.ClarifyingQuestions;

            // Populate patient SAMPLE history fields
            SignsSymptomsTextbox.Text = _patient.SignsAndSymptoms;
            AllergiesTextbox.Text = _patient.Allergies.ToString();
            MedicationsTextbox.Text = _patient.CurrentMedications.ToString();
            PastMedicalHistoryTextbox.Text = _patient.PastIllnesses.ToString();
            LastOralIntakeTextbox.Text = _patient.LastOralIntake;
            EventsTextbox.Text = _patient.Events;
            SignsSymptomsTextbox.Text = _patient.SignsAndSymptoms;
            SampleClarifyingQuestionsTextbox.Text = _patient.SampleClarifyingQuestions;

            // Populate additional Patient Assessment info fields
            if (_patient.MoiOrNoi)
            {
                MoiNoiComboBox.Text = "MOI";
            }
            else
            {
                MoiNoiComboBox.Text = "NOI";
            }

            MoiNoiDescriptionTextbox.Text = _patient.MoiNoiDescription;
            ChiefComplaintTextbox.Text = _patient.ChiefComplaint;
            CauseOfInjuryComboBox.Text = _patient.CauseOfInjury;
            ProviderNotesTextbox.Text = _patient.ProviderImpression;

            // Poulate EMS provier info fields
            if (_patient.Providers != null)
            {
                var provider1 = _patient.Providers[0];
                {
                    Provider1Name.Text = provider1.FullName();
                    Provider1LicenseTypeComboBox.Text = provider1.License.Classification.ToString();
                    Provider1LicenseNumber.Text = provider1.License.LicenseNumber;
                }

                if (_patient.Providers.Count > 1)
                {
                    var provider2 = _patient.Providers[1];
                    {
                        Provider2Name.Text = provider2.FullName();
                        Provider2LicenseTypeComboBox.Text = provider2.License.Classification.ToString();
                        Provider2LicenseNumber.Text = provider2.License.LicenseNumber;
                    }
                }

                if (_patient.Providers.Count > 2)
                {
                    var provider3 = _patient.Providers[2];
                    {
                        Provider3Name.Text = provider3.FullName();
                        Provider3LicenseTypeComboBox.Text = provider3.License.Classification.ToString();
                        Provider3LicenseNumber.Text = provider3.License.LicenseNumber;
                    }
                }
            }

            // Populate additional info fields
            GeneralCommentsTextbox.Text = _patient.ProviderComments;
            NarrativeTextbox.Text = _patient.Narrative;

            // Update Procedures & Treatments section checkboxes
            BleedingControlCheckbox.IsChecked = _patient.BleedingControl;
            BurnTreatmentCheckbox.IsChecked = _patient.BurnTreatment;
            CprCheckbox.IsChecked = _patient.Cpr;
            CervicalImmobilization.IsChecked = _patient.CSpine;
            GlucoseTreatmentCheckbox.IsChecked = _patient.GlucoseTreatment;
            TractionExtremitySplint.IsChecked = _patient.Splint;
            NarcanCheckbox.IsChecked = _patient.Narcan;
            NebulizerCheckbox.IsChecked = _patient.Nebulizer;
            ActivatedCharcoalCheckbox.IsChecked = _patient.ActivatedCharcoal;
            ChildbirthDeliveryCheckbox.IsChecked = _patient.ChildbirthDelivery;
            AirwayInsertionCheckbox.IsChecked = _patient.AirwayInsertion;
            VentilationCheckbox.IsChecked = _patient.VentilationTreatment;
            OtherTreatmentCheckbox.IsChecked = _patient.OtherTreatment;
        }

        public void SavePatientInfo()
        {
            // Save patient demographic info
            _patient.FirstName = FirstNameTextbox.Text;
            _patient.LastName = LastNameTextbox.Text;
            _patient.DateOfBirth = DateOfBirthDatePicker.Text;
            _patient.Age = AgeTextbox.Text;
            _patient.PatientHomeAddress.Street = StreetAddressTextbox.Text;
            _patient.PatientHomeAddress.State = StateTextbox.Text;
            _patient.PatientHomeAddress.City = CityTextbox.Text;
            _patient.PatientHomeAddress.ZipCode = StreetAddressTextbox.Text;
            _patient.Weight = WeightTextbox.Text;
            _patient.Gender = (DemographicEnums.Gender)GenderComboBox.SelectedIndex + 1;
            _patient.Race = (DemographicEnums.Race)RaceComboBox.SelectedIndex + 1;

            _patient.VitalsReadings = new List<Vitals.Vitals>();

            var vitalsSet = new Vitals.Vitals();
            //vitalsSet.Pulse.PulseQuality (VitalsEnums.PulseQuality) =  VitalsEnums.PulseQuality + 1;
            vitalsSet.Respirations.RespEffort = (VitalsEnums.RespEffort)RespEffortComboBox.SelectedIndex + 1;
            vitalsSet.Loc = (VitalsEnums.LocClassification)LocComboBox.SelectedIndex + 1;

            // Attempt to parse int values from textboxes
            try
            {
                vitalsSet.Pulse.PulseRate = Int32.Parse(PulseRateTextbox.Text);
                vitalsSet.BloodPressure.Systolic = Int32.Parse(BpDiastolicTextbox.Text);
                vitalsSet.BloodPressure.Diastolic = Int32.Parse(BpDiastolicTextbox.Text);
                vitalsSet.OxygenLevel.OxygenPercent = Int32.Parse(SP02Textbox.Text);
                vitalsSet.Respirations.RespirationRate = Int32.Parse(RespirationsTextbox.Text);
            }
            catch (System.FormatException)
            {
                //TODO: Invalid format handling
            }

            // Add the completed vitals set to the list
            _patient.VitalsReadings.Add(vitalsSet);

            // Save OPQRST fields
            _patient.Opqrst.Onset = OnsetTextbox.Text;
            _patient.Opqrst.Provocation = ProvocationTextbox.Text;
            _patient.Opqrst.QualityOfPain = QualityTextbox.Text;
            _patient.Opqrst.RegionAndRadiation = RadiationTextbox.Text;
            _patient.Opqrst.Severity = SeverityTextbox.Text;
            _patient.Opqrst.TimeSinceOnset = TimeTextbox.Text;
            _patient.Opqrst.ClarifyingQuestions = OpqrstClarifyingQuestionsTextbox.Text;

            // Save patient SAMPLE history fields
            _patient.SignsAndSymptoms = SignsSymptomsTextbox.Text;
            //_patient.Allergies = AllergiesTextbox.Text;
            //_patient.CurrentMedications = MedicationsTextbox.Text;
            //_patient.PastIllnesses = PastMedicalHistoryTextbox.Text;
            _patient.LastOralIntake = LastOralIntakeTextbox.Text;
            _patient.Events = EventsTextbox.Text;
            _patient.SignsAndSymptoms = SignsSymptomsTextbox.Text;
            _patient.SampleClarifyingQuestions = SampleClarifyingQuestionsTextbox.Text;

            // Save additional Patient Assessment info fields
            _patient.MoiOrNoi = (MoiNoiComboBox.Text == "MOI");

            _patient.MoiNoiDescription = MoiNoiDescriptionTextbox.Text;
            _patient.ChiefComplaint = ChiefComplaintTextbox.Text;
            _patient.CauseOfInjury = CauseOfInjuryComboBox.Text;
            _patient.ProviderImpression = ProviderNotesTextbox.Text;

            // Save EMS provier info fields
            if (Provider1Name.Text.Length > 0)
            {
                Provider provider1 = new Provider
                {
                    FirstName = Provider1Name.Text,
                    License =
                    {
                        Classification = (EmsEnums.LicenseClassification) Provider1LicenseTypeComboBox.SelectedIndex,
                        LicenseNumber = Provider1LicenseNumber.Text
                    }
                };
            }

            if (Provider2Name.Text.Length > 0)
            {
                Provider provider2 = new Provider
                {
                    FirstName = Provider2Name.Text,
                    License =
                    {
                        Classification = (EmsEnums.LicenseClassification) Provider2LicenseTypeComboBox.SelectedIndex,
                        LicenseNumber = Provider2LicenseNumber.Text
                    }
                };
            }

            if (Provider3Name.Text.Length > 0)
            {
                Provider provider3 = new Provider
                {
                    FirstName = Provider3Name.Text,
                    License =
                    {
                        Classification = (EmsEnums.LicenseClassification) Provider3LicenseTypeComboBox.SelectedIndex,
                        LicenseNumber = Provider3LicenseNumber.Text
                    }
                };
            }

            // Save additional info fields
            _patient.ProviderComments = GeneralCommentsTextbox.Text;
            _patient.Narrative = NarrativeTextbox.Text;

            // Save Procedures & Treatments section checkboxes
            _patient.BleedingControl = BleedingControlCheckbox.IsChecked == true;
            _patient.BurnTreatment = BurnTreatmentCheckbox.IsChecked == true;
            _patient.Cpr = CprCheckbox.IsChecked == true;
            _patient.CSpine = CervicalImmobilization.IsChecked == true;
            _patient.GlucoseTreatment = GlucoseTreatmentCheckbox.IsChecked == true;
            _patient.Splint = TractionExtremitySplint.IsChecked == true;
            _patient.Narcan = NarcanCheckbox.IsChecked == true;
            _patient.Nebulizer = NebulizerCheckbox.IsChecked == true;
            _patient.ActivatedCharcoal = ActivatedCharcoalCheckbox.IsChecked == true;
            _patient.ChildbirthDelivery = ChildbirthDeliveryCheckbox.IsChecked == true;
            _patient.AirwayInsertion = AirwayInsertionCheckbox.IsChecked == true;
            _patient.VentilationTreatment = VentilationCheckbox.IsChecked == true;
            _patient.OtherTreatment = OtherTreatmentCheckbox.IsChecked == true;

            // Clear and add the patient to the current PatientList
            Database.PatientList.Clear();
            Database.PatientList.Add(_patient);

        }

        private void PopulateComboBoxes()
        {
            // Populate Demographics combo boxes
            foreach (DemographicEnums.Gender value in Enum.GetValues(typeof(DemographicEnums.Gender)))
            {
                GenderComboBox.Items.Add(value.GetStringValue());
            }

            foreach (DemographicEnums.Race value in Enum.GetValues(typeof(DemographicEnums.Race)))
            {
                RaceComboBox.Items.Add(value.GetStringValue());
            }

            // Populate vitals combo boxes
            foreach (VitalsEnums.PulseQuality value in Enum.GetValues(typeof(VitalsEnums.PulseQuality)))
            {
                PulseQualityComboBox.Items.Add(value.GetStringValue());
            }

            foreach (VitalsEnums.PulsePoint value in Enum.GetValues(typeof(VitalsEnums.PulsePoint)))
            {
                PulseLocationComboBox.Items.Add(value.GetStringValue());
            }

            foreach (VitalsEnums.RespEffort value in Enum.GetValues(typeof(VitalsEnums.RespEffort)))
            {
                RespEffortComboBox.Items.Add(value.GetStringValue());
            }

            foreach (VitalsEnums.BpReadingLocation value in Enum.GetValues(typeof(VitalsEnums.BpReadingLocation)))
            {
                BpLocationComboBox.Items.Add(value.GetStringValue());
            }

            foreach (VitalsEnums.SkinTemp value in Enum.GetValues(typeof(VitalsEnums.SkinTemp)))
            {
                SkinTempComboBox.Items.Add(value.GetStringValue());
            }

            foreach (VitalsEnums.SkinMoisture value in Enum.GetValues(typeof(VitalsEnums.SkinMoisture)))
            {
                PulseLocationComboBox.Items.Add(value.GetStringValue());
            }

            foreach (VitalsEnums.TemperatureLocation value in Enum.GetValues(typeof(VitalsEnums.TemperatureLocation)))
            {
                BodyTempMethodComboBox.Items.Add(value.GetStringValue());
            }

            foreach (VitalsEnums.BloodGlucoseReadingLocation value in Enum.GetValues(typeof(VitalsEnums.BloodGlucoseReadingLocation)))
            {
                GcMethodComboBox.Items.Add(value.GetStringValue());
            }

            foreach (VitalsEnums.OxygenReadingMethod value in Enum.GetValues(typeof(VitalsEnums.OxygenReadingMethod)))
            {
                SP02LocationComboBox.Items.Add(value.GetStringValue());
            }

            foreach (VitalsEnums.Pupils value in Enum.GetValues(typeof(VitalsEnums.Pupils)))
            {
                PupilResponseComboBox.Items.Add(value.GetStringValue());
            }

            // Populate Patient Assessment ComboBoxes

            MoiNoiComboBox.Items.Add("Mechanism of Injury");
            MoiNoiComboBox.Items.Add("Nature of Injury");

            foreach (VitalsEnums.CauseOfInjury value in Enum.GetValues(typeof(VitalsEnums.CauseOfInjury)))
            {
                CauseOfInjuryComboBox.Items.Add(value.GetStringValue());
            }

            foreach (VitalsEnums.ProviderImpression value in Enum.GetValues(typeof(VitalsEnums.CauseOfInjury)))
            {
                ProviderImpressionComboBox.Items.Add(value.GetStringValue());
            }

            // Populate Medical Personel combo boxes

            foreach (EmsEnums.LicenseClassification value in Enum.GetValues(typeof(EmsEnums.LicenseClassification)))
            {
                Provider1LicenseTypeComboBox.Items.Add(value.GetStringValue());
                Provider2LicenseTypeComboBox.Items.Add(value.GetStringValue());
                Provider3LicenseTypeComboBox.Items.Add(value.GetStringValue());
            }

            foreach (EmsEnums.ProviderRole value in Enum.GetValues(typeof(EmsEnums.ProviderRole)))
            {
                Provider1Role.Items.Add(value.GetStringValue());
                Provider2Role.Items.Add(value.GetStringValue());
                Provider3Role.Items.Add(value.GetStringValue());
            }

        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            FileOps.LoadDatabase();
            if (Database.PatientList.Count > 0)
            {
                _patient = Database.PatientList.First();
                UpdatePatientInfo();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SavePatientInfo();
            if (FileOps.SaveDatabase())
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Failed To Save Database");
            }

        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
