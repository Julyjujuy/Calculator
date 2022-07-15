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


            int globalArea = 0;
            while (true)
            {
                Console.WriteLine("Enter Floor Width");
                string userInputWidth = Console.ReadLine();
                int NewUserInputWidth = Convert.ToInt32(userInputWidth);

                Console.WriteLine("Enter Floor Lenght");
                string userInputLenght = Console.ReadLine();
                int NewUserInputLenght = Convert.ToInt32(userInputLenght);
                int squareMeters = NewUserInputWidth * NewUserInputLenght;

                globalArea += squareMeters;
                Console.WriteLine("Is there any more Area to cover? 'Y' to add");
                string answer = Console.ReadLine().ToLower();

                if (answer != "y")
                {
                    break;
                }
            }
            //Console.WriteLine("Please Insert the Cost of 1 unit of Flooring");
            //string userInputUnitCost = Console.ReadLine();
            Console.WriteLine("Enter Cost per Unit");
            string userInputCost = Console.ReadLine();
            int NewUserInputCost = Convert.ToInt32(userInputCost);

            int CostOfFlooring = globalArea * NewUserInputCost;


            //decimal costPerSqmt = 86.00m / 20.00m;
            //decimal CostOfFlooring = globalArea * costPerSqmt;




            Console.WriteLine(CostOfFlooring);
            Console.ReadLine();


        }
    }
}


