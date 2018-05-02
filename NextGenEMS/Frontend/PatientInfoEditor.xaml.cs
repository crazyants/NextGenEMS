﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NextGenEMS.Backend;
using NextGenEMS.Data;
using NextGenEMS.People;

namespace NextGenEMS.Frontend
{
    /// <summary>
    /// Interaction logic for PatientInfoEditor.xaml
    /// </summary>
    public partial class PatientInfoEditor : Window
    {
        private static Patient patient;

        // Standard Constructor accepting a single patient object
        public PatientInfoEditor()
        {        
            // Create a new empty patient object
            patient = new Patient();

            //Initialize window
            InitializeComponent();
        }

        public void UpdatePatientInfo()
        {
            // Populate patient demographic fields
            FirstNameTextbox.Text = patient.FirstName;
            LastNameTextbox.Text = patient.LastName;
            DateOfBirthDatePicker.Text = patient.DateOfBirth;
            AgeTextbox.Text = patient.Age;
            StreetAddressTextbox.Text = patient.PatientHomeAddress.Street;
            StateTextbox.Text = patient.PatientHomeAddress.State;
            CityTextbox.Text = patient.PatientHomeAddress.City;
            StreetAddressTextbox.Text = patient.PatientHomeAddress.ZipCode;
            WeightTextbox.Text = patient.Weight;
            GenderComboBox.Text = patient.Gender.ToString();
            RaceComboBox.Text = patient.Race.ToString();

            // Populate patient vitals
            foreach (var vitalSet in patient.VitalsReadings)
            {
                VitalsTimestampListBox.Items.Add(vitalSet.Timestamp.TimeString);
            }

            if (VitalsTimestampListBox.Items.Count > 0)
            {
                var vitalsSet = patient.VitalsReadings.First();
                VitalsTimestampListBox.SelectedIndex = 0;
                PulseTextbox.Text = vitalsSet.Pulse.ToString();
                PulseQuality.Text = vitalsSet.PulseQuality.ToString();
                BpSystolic.Text = vitalsSet.BloodPressure.Systolic.ToString();
                BpDiastolic.Text = vitalsSet.BloodPressure.Diastolic.ToString();
                SP02Textbox.Text = vitalsSet.OxygenLevel.ToString();
                RespirationsTextbox.Text = vitalsSet.Respirations.ToString();
                RespEffortComboBox.Text = vitalsSet.RespEffort.ToString();
                LocComboBox.Text = vitalsSet.Loc.ToString();
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            FileOps.LoadDatabase();
            if (Database.PatientList.Count > 0)
            {
                patient = Database.PatientList.First();
                UpdatePatientInfo();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (FileOps.SaveDatabase())
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Failed To Save Database");
            }

        }
    }
}
