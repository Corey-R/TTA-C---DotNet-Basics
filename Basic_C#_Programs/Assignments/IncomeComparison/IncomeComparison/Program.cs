using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // MATH AND COMPARISON OPERATOR SUBMISSION ASSIGNMENT
            //-----------------------------------------------------------------

            // Display Name of Program 
            Console.WriteLine("Anonymous Income Comparison Program \n");

            // Person 1
            Console.WriteLine("\nPerson 1\n");
            Console.WriteLine("Please enter your Hourly Rate: ");
            string rate1 = Console.ReadLine();
            Console.WriteLine("\nHours worked per week? ");
            string hrsPerWeek1 = Console.ReadLine();

            // Person 2
            Console.WriteLine("\n\nPerson 2\n");
            Console.WriteLine("Please enter your Hourly Rate: ");
            string rate2 = Console.ReadLine();
            Console.WriteLine("\nHours worked per week? ");
            string hrsPerWeek2 = Console.ReadLine();

            //----------------------------
            // Getting Annual Salaries 
            //-------------------------------------

            // First, we need to convert string values to numeric values by: 
            decimal numRate1 = Convert.ToDecimal(rate1);
            decimal hrsWorked1 = Convert.ToDecimal(hrsPerWeek1);

            // Next, Perform basic math to get Person 1's Annual Salary: 
            // Multiply Rate by Hours per Week
            decimal weeklyEarnings1 = numRate1 * hrsWorked1;
            // Since there are 52 weeks in a year...
            // weeklyEarnings1 * 52 = 19,968
            decimal total1 = weeklyEarnings1 * 52;

            // Display Person 1's Annual Salary to the console...
            Console.WriteLine("\n\nAnnual salary for Person 1 is: \n" + total1.ToString());

            // Person 2's Annual Salary 
            decimal numRate2 = Convert.ToDecimal(rate2);
            decimal hrsWorked2 = Convert.ToDecimal(hrsPerWeek2);

            decimal weeklyEarnings2 = numRate2 * hrsWorked2;
            decimal total2 = weeklyEarnings2 * 52;

            Console.WriteLine("\n\nAnnual Salary for Person 2 is: \n" + total2.ToString());
           

            //-----------------------------------------
            // Boolean: Is Person 1s > Person 2s Salary
            //---------------------------------------------------

            // To start this, let's first create a bool variable that holds the value
            // of Person 1s annual > Person 2s annual
            bool whoMakesMore = total1 > total2;

            // Display results in Console.
            Console.WriteLine("\n\nDoes Person 1 make more than Person 2? \n" + whoMakesMore.ToString());
            Console.Read();


            
        }
    }
}
