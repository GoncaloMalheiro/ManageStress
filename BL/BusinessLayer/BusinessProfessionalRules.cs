/*
 
 * Authors: Gonçalo Malheiro, Joao Liama e Luis Gonçalves
 * Date: 8 / 12 / 2023
 * Emails: a26064@alunos.ipca.pt , a26545 @alunos.ipca.pt, a26061 @alunos.ipca.pt
 
*/

using BusinessObject;
using DataLayer;


namespace BusinessLayer
{
    public class BusinessProfessionalRules
    {
        /// <summary>
        /// BusinessProfessionalRule, add a professional if is age > 10
        /// </summary>
        /// <param name="p"</param>
        /// <returns></returns>
        public static bool AddProfessional(Professional p)
        {
            if (p.Age > 10)
            {
                return ManageProfessional.AddProfessional(p);
            }
            return false;
        }

        /// <summary>
        /// BusinessProfessionalRule, exist a professional if is Id != 0
        /// </summary>
        /// <param name="p"</param>
        /// <returns></returns>
        public static bool ExistProfessional(Professional p)
        {
            if (p.Id >= 0)
            {
                return ManageProfessional.ExistProfessional(p);
            }
            return false;
        }


        /// <summary>
        /// BusinessProfessionalRule, remove a professional if is Age > 66
        /// </summary>
        /// <param name="p"</param>
        /// <returns></returns>
        public static bool RemovePofessional(Professional p)
        {
            if (p.Age > 66)
            {
                return ManageProfessional.RemoveProfessional(p);
            }
            return false;
        }


        /// <summary>
        /// BusinessProfessionalRule, Clear Professionals
        /// </summary>
        /// <returns></returns>
        public static bool Clear()
        {

            return ManageProfessional.Clear();

        }

        /// <summary>
        ///BusinessProfessionalRule,Show Dictinary of Professionals
        /// </summary>
        public static bool ShowProfessional()
        {
            return ManageProfessional.ShowProfessional();
        }

        /// <summary>
        /// BusinessProfessionalRule, Save Professional Information
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <returns></returns>
        public static bool SaveProfessional(string fileName)
        {
            if (fileName == null) return false;
            {
                return ManageProfessional.SaveProfessional(fileName);
            }
        }

        /// <summary>
        /// BusinessProfessionalRule, Load Professional Information
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <returns></returns>
        public static bool LoadProfessional(string fileName)
        {
           if (fileName != "") 
            {
                return ManageProfessional.LoadProfessional(fileName);
            }
            return false;
        }
        

    }
}