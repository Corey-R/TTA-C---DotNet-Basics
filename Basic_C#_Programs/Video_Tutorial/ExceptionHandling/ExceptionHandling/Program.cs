using System;

class Program
{
    static void Main(string[] args)
    {
        // try this code
        try
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + "divided by " + numberTwo + "= " + numberThree);           
        }
        // catch any format errors (data type ex is for Format Exception)
        catch (FormatException ex)
        {
            // print exception message to console if thrown
            Console.WriteLine("Please enter a whole number.");
            return; // returns user to another page (exits the console)
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        // creates a general exception that catches all exceptions thrown
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        // finally placed at end of the try catch block
        // NOTE: if the try block runs perfectly with no exceptions, finally will still run.
        // NOTE: if there was an exception thrown, the finally block will still run
        finally
        {
            Console.Read();
        }
        
    }
}

