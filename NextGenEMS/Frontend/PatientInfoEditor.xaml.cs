using NextGenEMS.Backend;
using NextGenEMS.Data;
using NextGenEMS.Demographics;
using NextGenEMS.People;
using NextGenEMS.Vitals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

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
                    BloodGcTextbox.Text = vitalsSet.BloodGlucose.Value.ToString();
                    SP02Textbox.Text = vitalsSet.OxygenLevel.OxygenPercent.ToString();
                    
                    LocComboBox.Text = vitalsSet.Loc.ToString();
                }
            }
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
            _patient.Gender = (DemographicEnums.Gender) GenderComboBox.SelectedIndex + 1;
            _patient.Race = (DemographicEnums.Race) RaceComboBox.SelectedIndex + 1;

                _patient.VitalsReadings = new List<Vitals.Vitals>();

        var vitalsSet = new Vitals.Vitals();
            vitalsSet.Pulse.PulseQuality = (VitalsEnums.PulseQuality) PulseQuality.SelectedIndex + 1;
            vitalsSet.Respirations.RespEffort = (VitalsEnums.RespEffort) RespEffortComboBox.SelectedIndex + 1;
            vitalsSet.Loc = (VitalsEnums.LocClassification) LocComboBox.SelectedIndex + 1;

            // Attempt to parse int values from textboxes
            try
            {
                vitalsSet.Pulse.PulseRate = Int32.Parse(PulseTextbox.Text);
                vitalsSet.BloodPressure.Systolic = Int32.Parse(BpSystolic.Text);
                vitalsSet.BloodPressure.Diastolic = Int32.Parse(BpDiastolic.Text);
                vitalsSet.OxygenLevel.OxygenPercent = Int32.Parse(SP02Textbox.Text);
                vitalsSet.Respirations.RespirationRate = Int32.Parse(RespirationsTextbox.Text);
            }
            catch (System.FormatException)
            {
                //TODO: Invalid format handling
            }

            // Add the completed vitals set to the list
            _patient.VitalsReadings.Add(vitalsSet);

            // Clear and add the patient to the current PatientList
            Database.PatientList.Clear();
            Database.PatientList.Add(_patient);

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
