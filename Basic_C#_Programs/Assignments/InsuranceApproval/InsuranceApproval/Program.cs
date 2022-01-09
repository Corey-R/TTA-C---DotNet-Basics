using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSURANCE APPROVAL PROJECT
            //----------------------------------

            Console.WriteLine("Please answer these following questions: \n");

            // Application Questions
            //-----------------------------
            // Using Console to gather user's raw data for later 

            Console.WriteLine("\nHow old are you? ");
            // storing user's age inside variable "Age"
            string Age = Console.ReadLine();

            Console.WriteLine("\ntrue or false: Ever had a DUI?");
            string DUI = Console.ReadLine();

            Console.WriteLine("\nHow many speeding tickets do you have? Please enter the number.");
            string speedTicket = Console.ReadLine();

            // QUALIFICATION SECTION
            // Using Boolean Logic to determine if the applicant
            // is qualfied. 

            // Applicant must be over 15
            // convert string Age to an int data type
            int applicantAge = Convert.ToInt32(Age);
            // check if user'a age is over 15
            bool over15 = applicantAge > 15;

            // No DUIs 
            // convert string DUI to boolean
            bool chkDUIs = Convert.ToBoolean(DUI);
            // If the user does NOT have any DUIs (or false)
            // set noDUIs value to "true"
            bool noDUIs = chkDUIs != true;

            // No more than 3 speeding tickets
            // convert string speedTicket to int
            int spdTick = Convert.ToInt32(speedTicket);
            // set bool to true if user has less than or equal 
            // to 3 speeding tickets
            bool over3Ticks = spdTick <= 3;

            // PUT IT ALL TOGETHER
            // create a Qualified boolean variable using
            // AND && Operator 

            bool qualified = over15 && noDUIs && over3Ticks;

            // Print results in the console 
            Console.WriteLine("\n\nQualified? \n" + qualified);
            Console.Read();


        }
    }
}
