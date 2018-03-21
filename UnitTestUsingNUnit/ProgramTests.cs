using CITestingExample;
using NUnit.Framework;
using System;

namespace UnitTestUsingNUnit
{
    [TestFixture]
   public class ProgramTests
    {
        [TestCase("Harshad","Patel",ExpectedResult ="Harshad Patel",Description ="Name always have a Only Characters and WhiteSpace",TestName = "Positive Test Scenario One")]
        [TestCase("", "", ExpectedResult = "Input Values Can not be Null or Empty...", Description = "NULL Or Empty Name is not good..",TestName = "Negative Test Scenario One")]
        [TestCase("h12546453sf", "gh456", ExpectedResult = "Value Should Only Accept Characters and Whitespaces..", Description = "Name With Numbers is not good..",TestName= "Negative Test Scenario Two")]
        public string Add(string strFirstName, string strLastName)
        {
            string actualResult = string.Empty;
            try
            {
                actualResult = Program.Add(strFirstName, strLastName);
            }
            catch (Exception ex)
            {
                actualResult = ex.Message;
            }
            return actualResult;
        }

    }
}
