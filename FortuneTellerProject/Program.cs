using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Fortune Teller");

            Console.WriteLine("Please enter your first name");
            string firstName = (Console.ReadLine());
            Console.WriteLine("Please enter last name");
            string secondName = (Console.ReadLine());

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What month were you born in? (Please insert the month number)");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite color using ROYGBIV? \nIf you do not know what ROYGBIV is enter HELP.");
            string color = Console.ReadLine();



            if (color.ToUpper() == "HELP")     //if (color.IndexOf("HELP") != -1) ?

            {
                Console.WriteLine("Acornym for ROYGBIV is red, orange, yellow, green, blue, indigo, violet.");
                color = Console.ReadLine();
            }


            //Part 2 
            //Retire age

            int retireAge;
            int eoAge = age % 2;
            //Console.WriteLine(eoAge);

            if (age % 2 == 0)
            {
                retireAge = 10;
            }
            else
            {
                retireAge = 20;
            }

            //Sibilings & Location
            string home;


            if (siblings == 0)
            {
                home = "San Diego";
            }
            else if (siblings == 1)
            {
                home = "Miami";
            }
            else if (siblings == 2)
            {
                home = "Alaska";
            }
            else if (siblings == 3)
            {
                home = "Mexico";
            }
            else if (siblings > 3)
            {
                home = "Michigan";
            }
            else
            {
                home = "Little Box";
            }
             

            //Transportation 

                string transportation="";

                if (color == "red")
                {
                    transportation = "bike";
                }
                else if (color == "orange")
                {
                    transportation = "jet ski";
                }
                else if (color == "yellow")
                {
                    transportation = "car";
                }
                else if (color == "green")
                {
                    transportation = "skateboard";
                }
                else if (color == "blue")
                {
                    transportation = "boat";
                }
                else if (color == "indigo")
                {
                    transportation = "plane";
                }
                else if (color == "violet")
                {
                    transportation = "scooter";
                }
               

                // Bank Account 
                string bankaccount="";

                    if (month >= 1 && month <= 4)
                    {
                        bankaccount = "$5";
                    }
                    else if (month >= 5 && month <= 8)
                    {
                        bankaccount = "$10";
                    }
                    else if (month >= 9 && month <= 12)
                    {
                        bankaccount = "$200";
                    }
                    else
                    {
                        bankaccount = "$0";
                    }


         Console.WriteLine("{0} {1} will retire at {2} years old with {3} in the bank, a vacation home in {4} and {5}", firstName, secondName, retireAge, bankaccount, home, transportation);
        





          

            
        }
    }
}
