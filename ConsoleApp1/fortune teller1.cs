using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller_JackHallisy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part One User Interface Requirements

            string firstName;
            string lastName;
            string vacationCity = " ";
            string vehicle = " ";
            //string color = " ";
            //string result = " ";
            //string response;
            string retirementTime = " ";
            int age;
            int birthMonth;
            int numberOfSiblings;
            double bankAccount = 0.00;

            //Questions to User
            Console.WriteLine("What is your First Name?");
            firstName = Console.ReadLine().ToLower();


            Console.WriteLine("What is your Last Name?");
            lastName = Console.ReadLine().ToLower();


            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            //calculating retirement based on age being even or odd
            if (age % 2 == 0)
            {
                retirementTime = "ten years";
            }

            if (age % 2 != 0)
            {
                retirementTime = "fifteen years";
            }


            Console.WriteLine("What is your birth month?");
            birthMonth = int.Parse(Console.ReadLine());

            //calculating bank account based on birth month
            if ((birthMonth >= 1) && (birthMonth <= 4))
            {
                bankAccount = 500.00;
            }
            else if ((birthMonth >= 5) && (birthMonth <= 8))
            {
                bankAccount = 1500.00;
            }
            else if ((birthMonth >= 9) && (birthMonth <= 12))
            {
                bankAccount = 2500.00;
            }
            else if ((birthMonth > 12) || (birthMonth < 1))
            {
                bankAccount = 0.00;
            }
           

                Console.WriteLine("What is your favorite color based on the ROYGBIV spectrum or help if needed?");
            string response = Console.ReadLine().ToLower();

            //switch (color)
            //{
            //    case "red":
            //        Console.WriteLine("red.");
            //        break;

            //    case "orange":
            //        Console.WriteLine("orange.");
            //        break;

            //    case "yellow":
            //        Console.WriteLine("yellow.");
            //        break;

            //    case "green":
            //        Console.WriteLine("green.");
            //        break;

            //    case "blue":
            //        Console.WriteLine("blue.");
            //        break;

            //    case "indigo":
            //        Console.WriteLine("indigo.");
            //        break;

            //    case "violet":
            //        Console.WriteLine("violet.");
            //        break;

            //    case "help":
            //        Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
            //        break;
            //}


            if (response.Equals("red"))
            {
                vehicle = "Corvette";
            }
            else if (response.Equals("orange"))
            {
                vehicle = "Bug";
            }
            else if (response.Equals("yellow"))
            {
                vehicle = "Mustang";
            }
            else if (response.Equals("green"))
            {
                vehicle = "Jaguar";
            }
            else if (response.Equals("blue"))
            {
                vehicle = "Fairlane";
            }
            else if (response.Equals("indigo"))
            {
                vehicle = "Jetta";
            }
            else if (response.Equals("violet"))
            {
                vehicle = "Hummer";
            }
            else if (response.Equals("help"))
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                response = Console.ReadLine().ToLower();

                if (response.Equals("red"))
                {
                    vehicle = "Corvette";
                }
                else if (response.Equals("orange"))
                {
                    vehicle = "Bug";
                }
                else if (response.Equals("yellow"))
                {
                    vehicle = "Mustang";
                }
                else if (response.Equals("green"))
                {
                    vehicle = "Jaguar";
                }
                else if (response.Equals("blue"))
                {
                    vehicle = "Fairlane";
                }
                else if (response.Equals("indigo"))
                {
                    vehicle = "Jetta";
                }
                else if (response.Equals("violet"))
                {
                    vehicle = "Hummer";
                }

            }

            Console.WriteLine("how many siblings do you have?");
            numberOfSiblings = int.Parse(Console.ReadLine()); ;


            //calculate city based on number of siblings
            if (numberOfSiblings == 1)
            {
                vacationCity = "Syracuse";
            }

            else if (numberOfSiblings == 2)
            {
                vacationCity = "Chicago";
            }

            else if (numberOfSiblings == 3)
            {
                vacationCity = "Atlanta";
            }

            else if (numberOfSiblings > 3)
            {
                vacationCity = "Boston";
            }

            else if (numberOfSiblings < 0)
            {
                vacationCity = "Newark";
            }


            Console.WriteLine(firstName + lastName + "will retire in" + retirementTime + "with" + bankAccount + "in the bank, a vacation home in" + vacationCity + "with a" + vehicle);


        }
    }
}
