/*
 
 * Authors: Gonçalo Malheiro, Joao Liama e Luis Gonçalves
 * Date: 8 / 12 / 2023
 * Emails: a26064@alunos.ipca.pt , a26545 @alunos.ipca.pt, a26061 @alunos.ipca.pt
 
*/


using BusinessLayer;
using BusinessObject;
using System.Data;
using System.Reflection;
using System.Reflection.Metadata;


namespace FrontEnd
{
    public class FrontEnd
    {
        static void Main(string[] args)
        {
            Professional p0 = new Professional("Jose", 23, TypeProfessional.ASSISTANT); //creating object
            Console.WriteLine("Professional Name: {0}, Age: {1}, TypeProfessional: {2}", p0.Name, p0.Age, p0.Type); //show object


            if (BusinessProfessionalRules.AddProfessional(p0)) //Business Rule to add a professional in the list 
            {
                Console.WriteLine("\nProfessional Added Sucefully!\n");
            }
            else
                Console.WriteLine("\nFailed to Add a Professional!\n");

            Console.WriteLine("\nExist Jose: " + BusinessProfessionalRules.ExistProfessional(p0).ToString()); //Show if the Professional exist


            if (BusinessProfessionalRules.RemovePofessional(p0)) //Business Rule remove a professional in the list 
            {
                Console.WriteLine("\n\nProfessional Removed Sucefully!\n");
            }
            else
                Console.WriteLine("\n\nFailed to Remove a Professional!\n");


            Professional p1 = new Professional("Artur", 66, TypeProfessional.SECRETARY); //creating object

            Console.WriteLine("\n\nProfessional Name: {0}, Age: {1}, TypeProfessional: {2}", p1.Name, p1.Age, p1.Type); //show object


            if (BusinessProfessionalRules.AddProfessional(p1)) //Business Rule to add a professional in the list 
            {
                Console.WriteLine("\nProfessional Added Sucefully!\n");
            }
            else
                Console.WriteLine("\nFailed to Add a Professional!\n");

            Console.WriteLine("\nExist Artur: " + BusinessProfessionalRules.ExistProfessional(p1).ToString()); //Show if the Professional exist


            if (BusinessProfessionalRules.RemovePofessional(p1)) //Business Rule remove a professional in the list 
            {
                Console.WriteLine("\n\nProfessional Removed Sucefully!\n");
            }
            else
                Console.WriteLine("\n\nFailed to Remove a Professional!\n");


            if (BusinessProfessionalRules.ShowProfessional()) //Business Rule show a professional in the list 
            {
                Console.WriteLine("\n\nSucefully!\n");
            }
            else
                Console.WriteLine("\n\nFailed to Show a Professional!\n");




            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\Dados\\"; //The path used to save files


            bool b = BusinessProfessionalRules.SaveProfessional(path + "Professionals.bin"); //save the information of professionals in "professionals.bin"

            if (b)
            {
                Console.WriteLine("\n\nProfessionals saved successfully!");
            }
            else
            {
                Console.WriteLine("\nError saving Professionals.");
            }


            string path0 = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\Dados\\");
            string filePath = Path.Combine(path0, "Professionals.bin");

            bool loadSuccess = BusinessProfessionalRules.LoadProfessional(filePath); // load the information of professionals in "professionals.bin"

            if (loadSuccess)
            {
                Console.WriteLine("\nProfessionals loaded successfully!");
            }
            else
            {
                Console.WriteLine("\nError loading Professionals.");
            }



            Appointment ap1 = new Appointment(27, 37.6, 46, DateTime.Today); //creating object
           
            Console.WriteLine("\n\nAppointment: RespiratoryRate:{0}, SkinTemperature: {1} , HeartRate: {2} , Date: {3}", ap1.RespiratoryRate, ap1.SkinTemperature, ap1.HeartRate, ap1.Date); //show object


            if (BusinessAppointmentRules.AddAppointment(ap1)) //Business Rule to add a appointment in the list 
            {
                Console.WriteLine("\nAppointment Added Sucefully!\n");
            }
            else
                Console.WriteLine("\nFailed to Add a Appointment!\n");

            Console.WriteLine("\nExist Appointment: " + BusinessAppointmentRules.ExistsAppointment(ap1).ToString()); //Show if the appointment exist


            if (BusinessAppointmentRules.RemoveAppointment(ap1)) //Business Rule remove to a appointment in the list 
            {
                Console.WriteLine("\n\nAppointment Removed Sucefully!\n");
            }
            else
                Console.WriteLine("\n\nFailed to Remove a Appointment!\n");



            Appointment ap2 = new Appointment(30, 37.5, 47, DateTime.Today); //creating object

            Console.WriteLine("\n\nAppointment: RespiratoryRate:{0}, SkinTemperature: {1} , HeartRate: {2} , Date: {3}", ap2.RespiratoryRate, ap2.SkinTemperature, ap2.HeartRate, ap2.Date); //show object


            if (BusinessAppointmentRules.AddAppointment(ap2)) //Business Rule to add a appointment in the list 
            {
                Console.WriteLine("\nAppointment Added Sucefully!\n");
            }
            else
                Console.WriteLine("\nFailed to Add a Appointment!\n");

            Console.WriteLine("\nExist Appointment: " + BusinessAppointmentRules.ExistsAppointment(ap2).ToString()); //Show if the appointment exist


            if (BusinessAppointmentRules.RemoveAppointment(ap2)) //Business Rule remove  a appointment in the list 
            {
                Console.WriteLine("\n\nAppointment Removed Sucefully!\n");
            }
            else
                Console.WriteLine("\n\nFailed to Remove a Appointment!\n");


            if (BusinessAppointmentRules.ShowAppointment()) //Business Rule show a appointment in the list 
            {
                Console.WriteLine("\n\nSucefully!\n");
            }
            else
                Console.WriteLine("\n\nFailed to Show a Appointment!\n");


            string path2 = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\Dados\\"; //The path used to save 


            bool a = BusinessAppointmentRules.SaveAppointment(path2 + "Appointments.bin"); //save the information of appointments in "Appointments.bin"

            if (a)
            {
                Console.WriteLine("\n\nAppointments saved successfully!");
            }
            else
            {
                Console.WriteLine("\nError saving Appointments.");
            }



            string path1 = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\Dados\\");
            string filePath1 = Path.Combine(path1, "Appointments.bin");

            bool load = BusinessAppointmentRules.LoadAppointment(filePath1); // load the information of appointments in "appointments.bin"

            if (loadSuccess)
            {
                Console.WriteLine("\nAppointments loaded successfully!");
            }
            else
            {
                Console.WriteLine("\nError loading Appointments.");
            }


            Console.ReadKey();
        }
    }
}