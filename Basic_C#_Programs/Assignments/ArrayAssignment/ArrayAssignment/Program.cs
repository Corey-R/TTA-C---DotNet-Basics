using System;
using System.Collections.Generic;




class Program
{
    static void Main()
    {
        // ARRAYS SUBMISSION ASSIGNMENT
        //==============================================

        // print welcome message to the console...
        Console.WriteLine("Hi there, why don't we play a guessing game. \nHere, in this game you will be asked a series of questions and depending on which number you provide will \ndetermine your outcome. Good Luck!");

        // String Array
        //------------------
        // create the array of strings...
        string[] fruitArray = { "Apples", "Bananas", "Cherries", "Grapes", "Mangos", "Peaches", "Pears", "Strawberries", "Tomatoes", "Watermelons" };
        // creating a boolean variable for later use
        bool go = true;

        // print user instructions to console...
        Console.WriteLine("\n\nPlease enter a number 0 to 9.");               

        // while true, store user input into int variable and run branching statement...
        while (go)
        {
            int fruitNum = Convert.ToInt32(Console.ReadLine());
            // if the user met conditions, print index of array content to the console...
            if (fruitNum >= 0 && fruitNum <= 9)
            {
                Console.WriteLine("The fruit you selected was: \"" + fruitArray[fruitNum] + "\"");
                // this stops the loop
                go = false;
            }
            // otherwise, print an error message allowing the user another chance to make corrections..
            else
            {
                Console.WriteLine("Please enter a single digit number!");               
            }
        }
        
        // NOTE: Very similar code below so refer to above comments as reference... 

        // Integer Array
        //--------------------

        int[] intArray = { 2300, 1, 900, 10000, 30050090, 20, 5 };
        Console.WriteLine("\n\nNow, pick a number 0 to 6: ");
        bool start = true;

        while (start)
        {
            int guessedNum = Convert.ToInt32(Console.ReadLine());
            if (guessedNum >= 0 && guessedNum <= 6)
            {
                Console.WriteLine("Nice! Looks like you'll make " + intArray[guessedNum] + " dollars in the next month! \nYou know, sharing is caring...");
                start = false;
            }
            else
            {
                Console.WriteLine("Please enter a single digit number 0 to 6!");
            }
        }

        // String List
        //-----------------

        // this crates a list and adds values to the list
        List<string> stringList = new List<string>();
        stringList.Add("Welcome back!");
        stringList.Add("Good morning!");
        stringList.Add("That's my purse...I don't know you!");
        stringList.Add("Better watch your back!");
        stringList.Add("Winner! You won this message. Enjoy!");

        // print instructions
        Console.WriteLine("\n\nFinally, enter a number 0 to 4: ");
        bool set = true;

        // while true, perform the following..
        while (set)
        {
            int randomNum = Convert.ToInt32(Console.ReadLine());
            if (randomNum >= 0 && randomNum <= 4)
            {
                Console.WriteLine(stringList[randomNum]);
                set = false;
            }
            else
            {
                Console.WriteLine("Please enter a single digit number 0 to 4!");
            }
        }

        // print thank you for playing message
        Console.WriteLine("\n\nThanks for playing and being a great sport! See you next time!");

        // keeps the console open until user closes...
        Console.Read();
    }
}

