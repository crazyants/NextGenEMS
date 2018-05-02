using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using NextGenEMS.Constants;
using NextGenEMS.Data;
using NextGenEMS.People;

namespace NextGenEMS.Backend
{
    public class FileOps
    {
        /// <summary>
        /// Load the database file from the specified path
        /// </summary>
        /// <returns>false if the database file does not exist</returns>
        public static bool LoadDatabase(string path = ConstValues.DatabaseFileName)
        {
            //First check if the database file exists
            if (!File.Exists(path))
            {
                return false;
            }

            List<Patient> patientList;

            DataContractSerializer s = new DataContractSerializer(typeof(List<Patient>));
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                patientList = (List<Patient>)s.ReadObject(fs);
            }

            patientList.ForEach(p => Database.PatientList.Add(p));

            return true;
        }

        /// <summary>
        /// Save the database to the specified path. Delete any preexisting database files
        /// </summary>
        public static bool SaveDatabase(string path = ConstValues.DatabaseFileName)
        {
            var xmlWriterSettings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t"
            };

            DataContractSerializer s = new DataContractSerializer(typeof(List<Patient>));
            using (var xmlWriter = XmlWriter.Create(path, xmlWriterSettings))
            {
                s.WriteObject(xmlWriter, Database.PatientList);
            }
            return true;
        }


        /// <summary>
        /// Load preferences from the specified file path
        /// </summary>
        [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
        public static bool LoadPreferences(string path = ConstValues.PreferencesFileName)
        {
            //First check if the database file exists
            if (!File.Exists(path))
            {
                return false;
            }

            Preferences currentPreferences;

            DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(Preferences));
            using (FileStream fileStream = File.Open(path, FileMode.Open))
            {
                currentPreferences = (Preferences)dataContractSerializer.ReadObject(fileStream);
            }

//            Program.ShowSplashScreen = currentPreferences.ShowSplashScreen;
//            Program.RescanOnStartup = currentPreferences.RescanOnStartup;
//            Program.RestrictGlobalEsrbRatings = currentPreferences.RestrictGlobalEsrbRatings;
//            Program.UseModernEsrbLogos = currentPreferences.UseModernEsrbLogos;
//            currentPreferences.UserList.ForEach(u => Database.AddUser(u));

            return true;

        }

        /// <summary>
        /// Save preferences file to the specified path
        /// </summary>
        public static bool SavePreferences(string path = ConstValues.PreferencesFileName)
        {

            var xmlWriterSettings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t"
            };

            DataContractSerializer s = new DataContractSerializer(typeof(Preferences));
            using (var xmlWriter = XmlWriter.Create(path, xmlWriterSettings))
            {
                s.WriteObject(xmlWriter, Database.CurrentPreferences);
            }
            return true;
        }
    }
}
