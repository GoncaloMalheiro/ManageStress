/*
 
 * Authors: Gonçalo Malheiro, Joao Liama e Luis Gonçalves
 * Date: 8 / 12 / 2023
 * Emails: a26064@alunos.ipca.pt , a26545 @alunos.ipca.pt, a26061 @alunos.ipca.pt
 
*/

using BusinessLayer;
using BusinessObject;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Professional p1 = new Professional("Andre", 20, TypeProfessional.NURSE); //Create a Professional Object for Test

            //Act
            bool aux = BusinessProfessionalRules.AddProfessional(p1); //Calling the AddProfessional Method from BusinessProfessionalRules, to test the professional creation

            //Assert
            Assert.IsTrue(aux == true, "The Values of creation are not valid"); // Test Part

        }

        [TestMethod] 

        public void TestMethod2() 
        
        {
            //Arrange
            Professional p2 = new Professional("Manuel", 91, TypeProfessional.SECRETARY); //Create a Professional Object for Test

            //Act
            bool aux1 = BusinessProfessionalRules.AddProfessional(p2); //Calling the AddProfessional Method from BusinessProfessionalRules, to test the professional creation
            bool aux2 = BusinessProfessionalRules.RemovePofessional(p2); //Calling the RemoveProfessional Method from BusinessProfessionalRules, to test the professional creation

            //Assert
            Assert.IsTrue(aux1 == true, "The Values of creation are not valid"); // Test Part
            Assert.IsTrue(aux2 == true, "The Values of creation are not valid"); // Test Part


        }
    }
}