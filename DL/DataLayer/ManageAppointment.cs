/*
 
 * Authors: Gonçalo Malheiro, Joao Liama e Luis Gonçalves
 * Date: 8 / 12 / 2023
 * Emails: a26064@alunos.ipca.pt , a26545 @alunos.ipca.pt, a26061 @alunos.ipca.pt
 
*/

using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using BusinessObject;

namespace DataLayer
{
    [Serializable]
    public class ManageAppointment
    {
        [NonSerialized]

        #region State

        static Dictionary<DateTime, List<Appointment>> appointments; //state Dictionary appoitments
        static Dictionary<DateTime, List<Appointment>> clonedDictionaryAppointment; //state the cloned dictionary

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        static ManageAppointment()
        {
            appointments = new Dictionary<DateTime, List<Appointment>>();
            clonedDictionaryAppointment = new Dictionary<DateTime, List<Appointment>>();

        }

        #region OtherMethods

        /// <summary>
        ///Create a list with the id as a key and after check if the appointment cointains the specific id after insert in the list.
        /// </summary>
        /// <param name="ap"></param>
        /// <returns></returns>
        public static bool AddAppointment(Appointment ap)
        {
            if (!appointments.ContainsKey(ap.Date))
                appointments.Add(ap.Date, new List<Appointment>());
            if (!appointments[ap.Date].Contains(ap))
            {
                appointments[ap.Date].Add(ap);
                return true;

            }
            return false;

        }

        /// <summary>
        ///Check the list with the id as a key and after check if the appointment cointains the specific id and return true .
        /// </summary>
        /// <param name="ap"></param>
        /// <returns></returns>
        public static bool ExistAppointment(Appointment ap)
        {
            if (appointments.ContainsKey(ap.Date))
            {
                if (appointments[ap.Date].Contains(ap))
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        ///Check the list with the id as a key and after check if the appointment cointains the specific id and remove.
        /// </summary>
        /// <param name="ap"></param>
        /// <returns></returns>
        public static bool RemoveAppointment(Appointment ap)
        {
            if (appointments.ContainsKey(ap.Date))
            {
                if (appointments[ap.Date].Contains(ap))
                {
                    appointments[ap.Date].Remove(ap);
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        ///Copy dictionary, enter a key that corresponds to a value in the list, the key is the id, and the value corresponds to the appointment information
        /// </summary>
        /// <returns></returns>
        public static Dictionary<DateTime, List<Appointment>> ClonedDictinaryAppointment()
        {

            clonedDictionaryAppointment = appointments.ToDictionary(entry => entry.Key, entry => entry.Value);
            return clonedDictionaryAppointment;

        }


        /// <summary>
        /// Shows the dictionary, key correspond to a value in the list, by the id , value is the appointment information
        /// </summary>
        public static bool ShowAppointment()
        {
            ManageAppointment.ClonedDictinaryAppointment();

            foreach (KeyValuePair<DateTime, List<Appointment>> entry in clonedDictionaryAppointment)
            {
                Console.WriteLine($"\nDateTime: {entry.Key}");

                foreach (Appointment appointment in entry.Value)
                {
                    Console.WriteLine("\n" + appointment.ToString());
                }
            }

            return true;
        }


        /// <summary>
        /// Clear dictinary
        /// </summary>
        /// <returns></returns>
        public static bool ClearAppointment()
        {
            appointments.Clear();
            return true;
        }

        #endregion

        #region Files

        /// <summary>
        /// Save the appointment information
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <returns></returns>
        public static bool SaveAppointment(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, appointments);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Load the appoointment information
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <returns></returns>
        public static bool LoadAppointment(string fileName)
        {
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    appointments = (Dictionary<DateTime, List<Appointment>>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (FileLoadException e)
                {
                    throw e;
                }
            }
            return false;
        }



        #endregion

        #endregion

        #endregion

    }
}
