using System;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Name Game");

            Console.Write("What's your first name?");
            string firstName = Console.ReadLine();

            Console.Write("Whats your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were u born?");
            string city = Console.ReadLine();
          
            DisplayResult(ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city));

         
            DisplayResult(ReverseString(firstName) + " " +
                ReverseString(lastName) + " " +
                ReverseString(city)); 

          

            Console.ReadLine();


        }

        private static string ReverseString(string message)
        {

            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(
            string reversedFirstName,
            string reversedLastName,
            string reversedCity)
        {

            Console.Write("Results: ");
            Console.Write(string.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }

        private static void DisplayResult(string message)

        {

            Console.Write("Results: ");
            Console.Write(message);


        }


    }

}


