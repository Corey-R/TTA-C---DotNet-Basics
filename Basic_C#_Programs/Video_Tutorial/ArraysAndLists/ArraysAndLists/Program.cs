using System;
using System.Collections.Generic;




class Program
{
    static void Main()
    {
        // ARRAYS AND LISTS
        //=========================

        // Use Square Brackets [] when referring to arrays 
        // dataType[] variableName = new dataType[]; is required when using arrays

        // You have to define the size of the array before instantiating it

        // Below is the syntax stating 
        // integer array called "numArray" equals a new integer array that has
        // 5 numbers in it.
        int[] numArray = new int[5];

        // Now, you must individually give the numeric value in each index of the
        // array.
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        // THERE'S A BETTER WAY....

        // Instead of placing the size amount, add curly braces and enter your 
        // values when defining the array.
        int[] numArray1 = new int[]
        {
            5, 2, 10, 200, 5000, 600, 2300
        };

        // THERE'S AN EVEN FASTER WAY
        //---------------------------------------

        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300};

        // Change an array item by specifying the index
        // NOTE: You are limited to the size of the array once it has been 
        // defined with its values.
        numArray2[5] = 650;


        // LISTS 
        //=====================

        // List<dataType> variableName = new List<dataType>(); is the syntax
        // NOTE: Size amount does not have to be specified when defining the list.
        List<int> intList = new List<int>();

        // .Add() adds values to the list
        intList.Add(4);
        intList.Add(10);

        // .Remove() removes a value from the list
        intList.Remove(10);

        // String list example
        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Jesse");
        stringList.Remove("Jesse");

        // Print to console to check
        Console.WriteLine(stringList[0]);
        Console.Read();

    }
}

