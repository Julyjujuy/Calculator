using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {

        static void Main(string[] args)
        {


            double globalArea = 0;
            while (true)
            {
                Console.WriteLine("Enter Floor Width");
                string userInputWidth = Console.ReadLine();
                double NewUserInputWidth = Convert.ToDouble(userInputWidth);

                Console.WriteLine("Enter Floor Lenght");
                string userInputLenght = Console.ReadLine();
                double NewUserInputLenght = Convert.ToDouble(userInputLenght);
                double squareMeters = NewUserInputWidth * NewUserInputLenght;

                globalArea += squareMeters;
                Console.WriteLine("Is there any more Area to cover? 'Y' to add");
                string answer = Console.ReadLine().ToLower();

                if (answer != "y")
                {
                    break;
                }
            }

            Console.WriteLine("Enter Cost per Unit");
            string userInputCost = Console.ReadLine();
            double NewUserInputCost = Convert.ToDouble(userInputCost);

            double CostOfFlooring = globalArea * NewUserInputCost;


            //decimal costPerSqmt = 86.00m / 20.00m;
            //decimal CostOfFlooring = globalArea * costPerSqmt;




            Console.WriteLine(CostOfFlooring);
            Console.ReadLine();


        }
    }
}


