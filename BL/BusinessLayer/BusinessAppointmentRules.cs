/*
 
 * Authors: Gonçalo Malheiro, Joao Liama e Luis Gonçalves
 * Date: 8 / 12 / 2023
 * Emails: a26064@alunos.ipca.pt , a26545 @alunos.ipca.pt, a26061 @alunos.ipca.pt
 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataLayer;

namespace BusinessLayer
{ 
    public class BusinessAppointmentRules
    {
        /// <summary>
        ///BusinessAppointmentRule, add a appoint if ap.HeartRate>= 45 && ap.RespiratoryRate >= 25 && ap.SkinTemperature > 36
        /// </summary>
        /// <param name="ap"></param>
        /// <returns></returns>
        public static bool AddAppointment(Appointment ap)
        {
            if (ap.RespiratoryRate>= 25 && ap.SkinTemperature >= 36 && ap.HeartRate >= 45)
            {
                return ManageAppointment.AddAppointment(ap);
            }
            return false;
        }

        /// <summary>
        /// BusinessAppointmentRule, exist a appoointment if Date == DateTime.Now
        /// </summary>
        /// <param name="ap"></param>
        /// <returns></returns>
        public static bool ExistsAppointment(Appointment ap)
        {
           if (ap.Date == DateTime.Today)
            {
                return ManageAppointment.ExistAppointment(ap);
            }
           return false;
        }

        /// <summary>
        /// BusinessAppointmentRule, remove a appoointment if Date != DateTime.Today
        /// </summary>
        /// <param name="ap"></param>
        /// <returns></returns>
        public static bool RemoveAppointment(Appointment ap)
        {
            if (ap.Date != DateTime.Today)
            {
                return ManageAppointment.RemoveAppointment(ap);
            }
            return false;
        }


        /// <summary>
        /// BusinessAppointmentRule, clear a appoointment 
        /// </summary>
        /// <returns></returns>
        public static bool ClearAppointment()
        {

            return ManageAppointment.ClearAppointment();

        }

        /// <summary>
        ///BusinessAppointmentRule, Show Dictinary of Appointments
        /// </summary>
        public static bool ShowAppointment()
        {
            return ManageAppointment.ShowAppointment();
        }

        /// <summary>
        /// BusinessAppointmentRule, Save Appointment Information
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool SaveAppointment(string fileName)
        {
            if (fileName == null) return false;
            {
                return ManageAppointment.SaveAppointment(fileName);
            }
        }

        /// <summary>
        /// BusinessAppointmentRule, Load Apoointment Information
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool LoadAppointment(string fileName)
        {
            if (fileName != null) return false;
            {
                return ManageAppointment.LoadAppointment(fileName);
            }

        }

    }
}
