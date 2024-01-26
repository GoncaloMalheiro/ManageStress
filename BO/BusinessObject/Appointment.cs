/*
 
 * Authors: Gonçalo Malheiro, Joao Liama e Luis Gonçalves
 * Date: 8 / 12 / 2023
 * Emails: a26064@alunos.ipca.pt , a26545 @alunos.ipca.pt, a26061 @alunos.ipca.pt
 
*/

using System;
using System.Xml.Linq;

namespace BusinessObject
{
    [Serializable]
    public class Appointment
    {
        #region Atributes

        [NonSerialized]

        private int respiratoryRate; //RespiratoryRate used in the Appointment
        private double skinTemperature; //SkinTemperature used in the Appointment
        private int heartRate; //HeartRate used in the Appointment
        private DateTime date; //Date used in the Appointment


        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        /// Constructor (Polymorphism)
        /// </summary>
        public Appointment(int rr, double st, int hr ,DateTime d)
        {
            respiratoryRate = rr;
            skinTemperature = st;
            heartRate = hr;
            date = d;
        }

        #endregion

        #region Properties

        ///<summary>
        ///Respiratory Property
        ///</summary>
        public int RespiratoryRate
        {
            set { respiratoryRate = value; }
            get { return respiratoryRate; }
        }

        ///<summary>
        ///SkinTemperature Property
        ///</summary>
        public double SkinTemperature
        {
            set { skinTemperature = value; }
            get { return skinTemperature; }
        }

        ///<summary>
        ///HeartRate Property
        ///</summary>
        public int HeartRate
        {
            set { heartRate = value; }
           get { return heartRate; }
        }

        ///<summary>
        ///Date Property
        ///</summary>
        public DateTime Date
        {
            set { date = value; }
            get { return date; }
        }

        #endregion

        #region Override String

        /// <summary>
        /// Show the Appointment Information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return $"\nAppointment: RespiratoryRate:{RespiratoryRate}, SkinTemperature: {SkinTemperature}, HeartRate: {HeartRate}, Date: {Date}";
        }

        #endregion

        #endregion


    }
}