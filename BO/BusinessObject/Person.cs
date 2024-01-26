/*
 
 * Authors: Gonçalo Malheiro, Joao Liama e Luis Gonçalves
 * Date: 8 / 12 / 2023
 * Emails: a26064@alunos.ipca.pt , a26545 @alunos.ipca.pt, a26061 @alunos.ipca.pt
 
*/

using System;

namespace BusinessObject
{
    [Serializable]
    public class Person
    {
        #region Attributes

        protected int id;//Id used to get the IdPerson
        protected string name; //Name of the Person
        protected int age; //Age of the Person
        protected static int idPerson = 0; //IdPerson the Person id

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        /// Initializing variable idPerson 
        /// </summary>
        public Person()
        {
            idPerson++;
        }

        #endregion

        #region Properties

        /// <summary>
        ///Name Property
        /// </summary>
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        /// <summary>
        /// Age Property
        /// </summary>
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        /// <summary>
        /// Id Property
        /// </summary>
        public int Id
        {
            get { return id; } //Value controlled internally
        }

        #endregion

        #endregion

    }
}
