using System;
using System.Collections.Generic;
namespace Drinks_Machine_Final
{
    public class Menu
    {
        public static double userInput;
        public static bool tea = false, milk = false, sugar = false, coffee = false;

        public static void menu()
        {

            Console.WriteLine("Drinks Machine 9000");
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1,"Tea"},
                {2,"Coffee"},
                {3,"Quit"}
            };
        
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, {1}", item.Key, item.Value);
            }

            userInput = MethodLib.GetUserInputByte("Please choose an item:\n");

            do
            {
                switch (userInput)
                {
                    case 1:
                    Ingredients.drinksChoice = "Tea"; --Ingredients.Cups; --Ingredients.Tea;
                    Program.DrinksChoice();
                    Extras.SugarChoice();
                        break;
                    case 2:
                    Ingredients.drinksChoice = "Coffee"; --Ingredients.Cups; --Ingredients.Coffee;
                    Program.DrinksChoice();
                    Extras.SugarChoice();
                        break;
                    case 3:
                    MethodLib.Quit();

                        break;
                    default:
                        break;

                }
                
                Console.ReadKey();
            } while (userInput !=4);





            



        }

    }
}
