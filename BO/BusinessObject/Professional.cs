/*
 
 * Authors: Gonçalo Malheiro, Joao Liama e Luis Gonçalves
 * Date: 8 / 12 / 2023
 * Emails: a26064@alunos.ipca.pt , a26545 @alunos.ipca.pt, a26061 @alunos.ipca.pt
 
*/


using System;

public enum TypeProfessional
{
    SECRETARY, //Professional Type
    NURSE, //Professional Type
    ASSISTANT, //Professional Type
}



namespace BusinessObject
{
    [Serializable]
    public class Professional : Person
    {
        #region Attributes

        private TypeProfessional type; //TypeProfessional the type of Professional

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        /// Constructor (Polymorphism)
        /// </summary>
        public Professional(string n, int idade, TypeProfessional t)
        {
            id = idPerson;
            name = n;
            age = idade;
            type = t;
        }

        #endregion

        #region Properties

        /// <summary>
        /// TypeProfessional Property
        /// </summary>
        public TypeProfessional Type
        {
            set { type = value; }
            get { return type; }

        }

        #endregion

        #region Override String

        /// <summary>
        /// Show the Professional Information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return $"\nProfessional Name: {Name}, Age: {Age}, TypeProfessional: {Type}";
        }

        #endregion

        #endregion

    }
}
