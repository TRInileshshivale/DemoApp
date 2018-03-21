using System;
using System.Text.RegularExpressions;

namespace CITestingExample
{
   public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string strFirstName = Console.ReadLine();
                string strLastName = Console.ReadLine();
                Console.WriteLine(Add(strFirstName, strLastName));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        public static string Add(string strFirstName, string strLastName)
        {
            if (string.IsNullOrEmpty(strFirstName) || string.IsNullOrEmpty(strLastName))
            {
                throw new Exception("Input Values Can not be Null or Empty...");
            }
            Regex regex = new Regex(@"^([a-zA-Z]+\s)*[a-zA-Z]+$");
            if (!(regex.IsMatch(strFirstName) || regex.IsMatch(strLastName)))
            {
                throw new Exception("Value Should Only Accept Characters and Whitespaces..");
            }

            return string.Concat(strFirstName, " ", strLastName);
        }
    }
}
