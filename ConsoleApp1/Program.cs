using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
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
            string color = " ";
            string result = " ";            
            string retirementTime = " ";
            int age;
            int birthMonth;
            int numberOfSiblings;
            double bankAccount;          

            


            Console.WriteLine("What is your First Name?");
            firstName = Console.ReadLine().ToLower();


            Console.WriteLine("What is your Last Name?");
            lastName = Console.ReadLine().ToLower();


            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());


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


            if ((birthMonth >= 1) && (birthMonth <= 4))
            {
                bankAccount = 500.00;
            }
            if ((birthMonth >= 5) && (birthMonth <= 8)) 
            {
                bankAccount = 1500.00;
            }
            if ((birthMonth >= 9) && (birthMonth <= 12)) 
            {
                bankAccount = 2500.00;
            }
            if ((birthMonth > 12) && (birthMonth < 1)) 
            {
                bankAccount = 0.00;
            }

            Console.WriteLine("how many siblings do you have?");
            numberOfSiblings = int.Parse(Console.ReadLine()); ;

            if (numberOfSiblings == 1)
            {
                vacationCity = "Syracuse";
            }
        
            if (numberOfSiblings == 2)
            {
                vacationCity = "Chicago";
            }

            if (numberOfSiblings == 3)
            {
                vacationCity = "Atlanta";
            }

            if (numberOfSiblings > 3)
            {
                vacationCity = "Boston";
            }

            if (numberOfSiblings < 0)
            {
                vacationCity = "Newark";
            }



            //}
            //else if ((birthMonth >= 5) && (birthMonth <= 8))
            //{
            //    int birthMonth = int.Parse(Console.ReadLine());
            //}
            //else if ((birthMonth >= 9) && (birthMonth <= 12))
            //{
            //    int birthMonth = int.Parse(Console.ReadLine());
            //}
            //else if ((birthMonth > 12) || (birthMonth < 1))
            //{ }
            //    int birthMonth = int.Parse(Console.ReadLine());

            //    }


            Console.WriteLine("What is your favorite color based on the ROYGBI spectrum or help if needed?");

              string response = Console.ReadLine().ToLower();

            switch (color)
            {
                case "red":
                    Console.WriteLine("red.");
                    break;

                case "orange":
                    Console.WriteLine("orange.");
                    break;

                case "yellow":
                    Console.WriteLine("yellow.");
                    break;

                case "green":
                    Console.WriteLine("green.");
                    break;

                case "blue":
                    Console.WriteLine("blue.");
                    break;

                case "indigo":
                    Console.WriteLine("indigo.");
                    break;

                case "violet":
                    Console.WriteLine("indigo.");
                    break;

                case "help":
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    break;


                default:
                    Console.WriteLine(response);
                    break;
            }

            //default:
            //    Console.WriteLine("help.");
            //    break;
        }


            if (response.Equals("red"))
            {
                Console.WriteLine("Corvette {0}", result);
            }
            else if (response.Equals("orange"))
            {
                Console.WriteLine("Bug {0}", result);
            }
            else if (response.Equals("yellow"))
            {
                Console.WriteLine("Mustang {0}", result);
            }
            else if (response.Equals("green"))
            {
                Console.WriteLine("Jaguar {0}", result);
            }
            else if (response.Equals("blue"))
            {
                Console.WriteLine("Fairlane {0}", result);
            }
            else if (response.Equals("indigo"))
            {
                Console.WriteLine("Jetta {0}", result);
            }
            else if (response.Equals("violet"))
            {
                Console.WriteLine("Hummer {0}", result);
            }

            else
            {
                Console.WriteLine(response);
            }

            {
                Console.WriteLine(firstName + lastName + "will retire in" + retirementTime + "with" + bankAccount + "in the bank, a vacation home in" + vacationCity, + "with a" + vehicle.);
            { 

        }    
    }
}
