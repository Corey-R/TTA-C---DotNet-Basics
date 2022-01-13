using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        // ITERATION VIDEO TUTORIAL
        //====================================

        // int[] testScores = {98, 99, 85, 70, 82, 34, 91, 90, 94};

        // To iterate through this array, we will use a for loop which is similar to Javascript's syntax

        // inside the parenthesis of the for loop are 3 conditions:
        // (starting value; for how long? (condition to meet); and what is done after each iteration is
        // done;
        // What you want done inside the for loop will be in curly braces..

        //for (int i = 0; i < testScores.Length; i++)
        //{
        // if testScores at index [i] is greater than 85, they passed
        //if (testScores[i] > 85)
        //{
        // this will print for every iteration that is passing in the array
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]);
        //}

        // ITERATIONS FOR LISTS
        //------------------------------

        // List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        // foreach Loop
        // To clarify, "score" is just a variable, you can name it "i" or whatever you want...
        // Defined as: 
        // foreach (variable in List<>, do something
        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        // As a reminder, the variable "score" represents the index of the list
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}

        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}

        // ADDING FROM ONE LIST TO ANOTHER IF CONDITION IS MET

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        // .Count gives you the total number of values in the list
        // .length is the .Count equivalence for an Array
        Console.WriteLine(passingScores.Count);
        Console.Read();
    }
}

