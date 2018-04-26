using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4WK1
{

    class SquareCube
    {
        static void Main()
        {

            while (true)
            {
                Console.Write("Enter a Number.\n\nYour selection: ");
                int j = Convert.ToInt32(Console.ReadLine());

                //Padding
                Console.WriteLine(string.Format("\n{0,-10} {1,-10} {2,-10}", "Number", "Squared", "Cubed"));
                Console.WriteLine(string.Format("{0,-10} {1,-10} {2,-10}", new string('=',7), new string('=', 7), new string('=', 7)));

                for (int i = 1; i <= j; i++)
                {
                    // sum = j * sum;
                    Console.WriteLine(string.Format("{0,-10} {1,-10} {2,-10}" ,i ,  i * i ,  i * i * i));
                    
                }

                //Continue y/n
                
                Console.Write("\nWould you like to continute Y/N; ");
                string input = Console.ReadLine();

                if (input.ToLower() == "n")
                {
                    break;
                }

            }
        }
    }
}
