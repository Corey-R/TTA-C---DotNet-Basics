using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        // 6-PART ITERATION ASSIGNMENT 
        //=======================================

        // Part One
        //--------------


        // creating a string Array 
        string[] names = { "Alex ", "Baron ", "Carlotta ", "Danielle " };

        // print instructions to console for user to enter some text
        Console.WriteLine("Enter text of whatever you'd like. ");
        string userText = Console.ReadLine();

        // This block of code will iterate through each element in the array and add the user's text
        // at the end of each element. 
        for (int i = 0; i < names.Length; i++)
        {
            // this sets a new value for current index of the array, for example:
            // "Alex " = "Alex " + "whatever user adds"
            names[i] = names[i] + userText;
        }

        // Iterating through edited Array and printing out each element in the array on a separate line
        for (int c = 0; c < names.Length; c++)
        {
            Console.WriteLine("\n" + names[c]);
        }

        // Part Two
        //-----------------

        // Braking the console by creating an infinite loop
        // While loops are known for accidental infinite loops
        //bool infinite = true;
        //while (infinite)
        //{
        //    Console.WriteLine("I am a virus--Deal with it!!!");
        //}

        // Here's how to fix that...
        // simply set the boolean value of infinite to false under the while statement

        bool infinite = true;
        while (infinite)
        {
            Console.WriteLine("\n\nI am a virus--Deal with it!!!");
            infinite = false;
        }

        // Part Three
        //------------------


        // < Comparison Loop
        int[] numbers = { 32, 42, 52, 99, 0, 33, 75 };

        // creating a for loop to iterate through the array
        for (int i = 0; i < numbers.Length; i++)
        {
            // if the value in array element is less than 3, stop the iteration
            // Since 0 < 3, nothing after 99 in the array will be printed to the console
            if (numbers[i] < 3)
            {
                // this stops the iteration
                break;
            }
            else
            {
                // Otherwise, print the element
                Console.WriteLine("\n" + numbers[i]);
            }
        }

        // = Operator Comparison

        // First, create a list of names
        List<string> newNames = new List<string>() { "Allison", "Boris", "Cathy", "Dout", "Evan" };

        // Start a foreach loop that cycles through the list of names
        foreach (string name in newNames)
        {
            // If during the iteration, one of the names matches "Boris" 
            // print "Boris" and stop the iteration
            if (name == "Boris")
            {
                Console.WriteLine(name);
                break;
            }
            // Otherwise, continue iterating and printing out each element as you go
            else
            {
                Console.WriteLine("\n" + name);
            }
        }

        // Part Four
        //-----------------

        // List of strings where each item is unique
        List<string> fruits = new List<string>() { "apples", "bananas", "cherries", "blueberries", "strawberries", "watermelons", "peaches", "pears", "plums", "tomatoes", "pineapples" };

        // prompts to user to enter a fruit
        Console.WriteLine("\n\nSearch for your favorite fruit below: ");
        bool start = true;

        while (start)
        {
            string search = Console.ReadLine().ToLower(); // .ToLower() removes capital format         
            // this if statement allows for a "no matches found" message if no terms match
            if (fruits.Contains(search)) // this returns true if term is a match and starts loop
            {
                // iterates through the "fruits" Lists
                for (int i = 0; i < fruits.Count; i++)
                {
                    // if there's a match (which there will be) print to console
                    // NOTE: you could also use if (fruits[i] == search)
                    if (fruits[i].StartsWith(search))
                    {
                        // this displays both the value and index of the matching element
                        Console.WriteLine("\nYour fruit \"" + fruits[i] + "\" is number " + i + " on our list.");
                        start = false; // stops while loop
                        // stops iteration after first match is found
                        break;
                    }
                }
            }
            else
            {
                // if no match, print info message to console
                Console.WriteLine("\nNo matches found. Note: All fruits in our records are plural. \n\"Example: For Strawberry search for 'strawberries'.\"");
            }

        }

        // Part Five
        //--------------------

        // creating color list with two identical strings
        List<string> colors = new List<string>() { "red", "blue", "yellow", "green", "red", "purple", "pink", "purple", "red", "black", "white", "gray", "blue", "green", "orange", "brown" };

        // prompt user to enter a color
        Console.WriteLine("\n\nWhat is your favorite color: ");
        bool cycle = true;

        while (cycle)
        {
            string response = Console.ReadLine().ToLower(); // gets user's response
            // if the "colors" list contains any elements that match user's input...
            if (colors.Contains(response))
            {
                // iterate through the entire colors list
                for (int i = 0; i < colors.Count; i++)
                {
                    if (colors[i] == response) // if there's a match...
                    {
                        // print each message displaying the index of each matching element
                        Console.WriteLine("\nWe've found a match in position " + i + " from our records.");
                        cycle = false; // stop loop
                    }
                }
            }
            else
            {
                // print that the list doesn't contain any elements matching user's input
                Console.WriteLine("\nWe did not find a match with text \"" + response + "\" \nPlease try another color...");
            }

        }

        // Part Six
        //--------------

        // creating list of strings with at least two identical strings        
        List<string> states = new List<string>() { "MS", "AL", "OR", "CA", "FL", "NY", "MS", "CA", "OR", "TX" };
        // creating two empty lists for later use
        List<string> singles = new List<string>();
        List<string> duplicates = new List<string>();

        // promts user to enter an abbreviated state
        Console.WriteLine("\n\nEnter abbreviated state below (such as 'AZ' for Arizona): ");
        string userState = Console.ReadLine().ToUpper();

        // create foreach loop to iterate through states list
        foreach (string state in states)
        {
            // if user's input matches a state in the list
            if (state == userState)
            {
                // if empty list 'singles' does NOT contain the targeted state
                if (!singles.Contains(state))
                {
                    singles.Add(state); // add selected state to the List
                }
                // Otherwise if selected state already exists in singles list, add it to the duplicates
                // list instead
                else
                {
                    duplicates.Add(state);
                }
            }
            
        }
        // if duplicates list contains an element (meaning it already exists)...
        if (duplicates.Count > 0)
        {
            // print to the console that the user's selected state already appeared elsewhere
            Console.WriteLine("Your state \"" + userState + "\" has already appeared.");
        }
        // Otherwise, if there are no elements in the duplicates list...
        else
        {
            // if singles list has at least one element...
            if (singles.Count > 0)
            {
                // print to the user that their selected state only has one entry in the list
                Console.WriteLine("Your state \"" + userState + "\" has appeared only once.");
            }
            // Otherwise if the user's input does not exist in any of the tables...
            else
            {
                // print to the user that their selected state is not on our list
                Console.WriteLine("Your state \"" + userState + "\" does not exist in our database.");
            }
            
        }
        Console.Read();
    }
}

