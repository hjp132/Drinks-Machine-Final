using System;
using System.Collections.Generic;
using System.Linq;

namespace Drinks_Machine_Final
{
    
    class Program
    {
        
        char response;

        static void Main(string[] args)
        {
            Menu.menu();
        }

        public static void DrinksChoice()
        {
            Console.WriteLine("You have chosen: " + Ingredients.drinksChoice + ".");

        }

    }

    public class Extras
    {
        public static string extrasChoice;
        public static void SugarChoice()
        {
            Console.WriteLine("\nWould you like Sugar?");
            extrasChoice = Console.ReadKey().KeyChar.ToString().ToLower();
            if (extrasChoice == "y")
            {
                Console.WriteLine("You have selected with Sugar");
                Ingredients.bSugar = true;
                
            }
            else{
                Console.WriteLine("No Sugar Selected");
            }
            Extras.MilkChoice();
            

        }
        public static void MilkChoice()
        {
            string message = "\nWould you like Milk? y/n:";
            Console.WriteLine(message);
            // uses .ReadKey().KeyChar.ToString().ToLower() so that the user cannot input more than one character and that it will be lowercase, allowing for it to be easier to validate
           extrasChoice = Console.ReadKey().KeyChar.ToString().ToLower();
            if (extrasChoice == "y")
            {
                Console.WriteLine("You have selected wth Milk");
                Ingredients.bMilk = true;
                
            }
            else{
                Console.Write("No Milk Selected");
            }
        }
    }











    public class MethodLib
    {

        public static int GetUserInputByte(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void Quit()
        {
            Console.WriteLine("\nThank you for using the temperature conversion application.\n");
            // quits the application
            System.Environment.Exit(1);
        }
        public static void valueInput()
        {
            // takes the pre-existing userInput as well as the GetuserInputByte, as this line is used at multiple points I decided to make a method for it
            Menu.userInput = GetUserInputByte("\nPlease enter a value to convert:\n");
        }
        
    }

    
}
