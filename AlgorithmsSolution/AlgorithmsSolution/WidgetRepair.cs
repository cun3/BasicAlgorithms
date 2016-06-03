using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// When a widget breaks, it is sent to the widget repair shop, which is capable of repairing at most numPerDay widgets per day. Given a record of the number of widgets that arrive at the shop each morning, your task is to determine how many days the shop must operate to repair all the widgets, not counting any days the shop spends entirely idle.
//For example, suppose the shop is capable of repairing at most 8 widgets per day, and over a stretch of 5 days, it receives 10, 0, 0, 4, and 20 widgets, respectively.The shop would operate on days 1 and 2, sit idle on day 3, and operate again on days 4 through 7. In total, the shop would operate for 6 days to repair all the widgets.
//Create a class WidgetRepairs containing a method days that takes a sequence of arrival counts arrivals(of type int[]) and an int numPerDay, and calculates the number of days of operation.
//Definition
//Class: 	WidgetRepairs
//Method: 	days
//Parameters: 	int[], int
//Returns: 	int
//Method signature:	int days(int[] arrivals, int numPerDay)

//Constraints
//-arrivals contains between 1 and 20 elements, inclusive.
//-Each element of arrivals is between 0 and 100, inclusive.
//-numPerDay is between 1 and 50, inclusive.


namespace AlgorithmsSolution
{
    class WidgetRepair
    {
        static void Main(string[] args)
        {
            int[] arrivals;
            int numPerDay = -1;
            int n = -1;
            int arrayValues;

            //Validation for the number of elements in the array.
            while (n != 0)
            {
                Console.Write("Please enter the number of values in the array between 1 and 20 inclusive ");

                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("The value selected is not a number.Try again");
                    n = -1;
                }
                else
                {
                    if (n < 0 || n > 20)
                    {
                        Console.Write("Try again.Select a number  between 1 and 20 inclusive ");
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (n > 0 || n < 21)
                    {
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            //Validation fo number of widgets repaired per day
            while (numPerDay != 0)
            {
                Console.Write("Please enter the number of widgets repaired in a day between 1 and 50 inclusive ");

                if (!int.TryParse(Console.ReadLine(), out numPerDay))
                {
                    Console.Write("The value selected is not a number.Try again");
                    numPerDay = -1;
                }
                else
                {
                    if (numPerDay < 0 || numPerDay > 20)
                    {
                        Console.Write("Try again.Select a number  between 1 and 50 inclusive ");
                        numPerDay = Convert.ToInt32(Console.ReadLine());

                    }
                    else if (numPerDay > 0 || numPerDay < 21)
                    {
                        numPerDay = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            arrivals = new int[n];

            Console.WriteLine("Enter the value of the array");
            for (int i = 0; i < n; i++)
            {
                arrayValues = Convert.ToInt32(Console.ReadLine());
                arrivals[i] = arrayValues;
            }

            int noOfDays = days(arrivals, numPerDay);
            Console.WriteLine(noOfDays.ToString());
        }

        public static int days(int[] arrivals, int numPerDay)
        {
            int balanceRemaining = 0;
            int noOfDays = 0;

            foreach (int count in arrivals)
            {
                balanceRemaining += count;
                if (balanceRemaining > numPerDay)
                {
                    balanceRemaining -= numPerDay;
                    noOfDays++;
                }
                else if (balanceRemaining > 0)
                {
                    balanceRemaining = 0;
                    noOfDays++;
                }
            }

            noOfDays += (int)(Math.Ceiling((double)balanceRemaining / numPerDay));

            return noOfDays;
        }
    }
}
