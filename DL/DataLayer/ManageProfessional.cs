/*
 
 * Authors: Gonçalo Malheiro, Joao Liama e Luis Gonçalves
 * Date: 8 / 12 / 2023
 * Emails: a26064@alunos.ipca.pt , a26545 @alunos.ipca.pt, a26061 @alunos.ipca.pt
 
*/


using BusinessObject;
using System.Runtime.Serialization.Formatters.Binary;


namespace DataLayer
{
    [Serializable]
    public class ManageProfessional
    {
        #region State

        [NonSerialized]

        static Dictionary<int, List<Professional>> professionals; //state Dictionary professionals
        static Dictionary<int, List<Professional>> clonedDictionary; //state the cloned dictionary

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        static ManageProfessional()
        {
            professionals = new Dictionary<int, List<Professional>>();
            clonedDictionary = new Dictionary<int, List<Professional>>();

        }

        #region OtherMethods

        /// <summary>
        ///Create a list with the id as a key and after check if the professional cointains the specific id after insert in the list.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool AddProfessional(Professional p)
        {
            if (!professionals.ContainsKey(p.Id))
                professionals.Add(p.Id, new List<Professional>());
            if (!professionals[p.Id].Contains(p))
            {
                professionals[p.Id].Add(p);
                return true;

            }
            return false;

        }

        /// <summary>
        ///Check the list with the id as a key and after check if the professional cointains the specific id and return true .
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool ExistProfessional(Professional p)
        {
            if (professionals.ContainsKey(p.Id))
            {
                if (professionals[p.Id].Contains(p))
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        ///Check the list with the id as a key and after check if the professional cointains the specific id and remove.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool RemoveProfessional(Professional p)
        {
            if (professionals.ContainsKey(p.Id))
            {
                if (professionals[p.Id].Contains(p))
                {
                    professionals[p.Id].Remove(p);
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        ///Copy dictionary, enter a key that corresponds to a value in the list, the key is the id, and the value corresponds to the professional information
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, List<Professional>> ClonedDictinary()
        {

            clonedDictionary = professionals.ToDictionary(entry => entry.Key, entry => entry.Value);
            return clonedDictionary;

        }


        /// <summary>
        /// Shows the dictionary, key correspond to a value in the list, by the id , value is the professional information
        /// </summary>
        /// <summary>
        public static bool ShowProfessional()
        {
            ManageProfessional.ClonedDictinary();

            foreach (KeyValuePair<int, List<Professional>> entry in clonedDictionary)
            {
                Console.WriteLine($"\nId: {entry.Key}");

                foreach (Professional professional in entry.Value)
                {
                    Console.WriteLine("\n" + professional.ToString());
                }
            }

            return true;
        }

        /// <summary>
        /// Clear dictinary
        /// </summary>
        /// <returns></returns>
        public static bool Clear()
        {
            professionals.Clear();
            return true;
        }

        #endregion

        #region Files

        /// <summary>
        /// Save the professional information
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool SaveProfessional(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, professionals);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Load the professional information
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool LoadProfessional(string fileName)
        {
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    professionals = (Dictionary<int, List<Professional>>)bin.Deserialize(stream);
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