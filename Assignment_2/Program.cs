using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program program = new Program();
                program.Go();
            }
            catch (Exception Msg)
            {
                Console.WriteLine(Msg.Message);
            }
            Console.ReadKey();
        }
        public void Go()
        {
            int TriangleDimensionOne, TriangleDimensionTwo, TriangleDimensionThree;
            do
            {
                int select;
                do
                {
                    Console.WriteLine("1. Enter triangle dimensions");
                    Console.WriteLine("2. Exit");
                    Console.Write("Select Your Choice :- ");
                } while ((!int.TryParse(Console.ReadLine(), out select)) || select < 1 || select > 2);

                switch (select)
                {
                    case 1:

                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Enter dimension of triangle");

                        do
                        {
                            Console.Write("Enter 1st dimension of triangle :-  ");
                        } while ((!int.TryParse(Console.ReadLine(), out TriangleDimensionOne)) || TriangleDimensionOne < 1);

                        do
                        {
                            Console.Write("Enter 2nd dimension of triangle :-  ");
                        } while ((!int.TryParse(Console.ReadLine(), out TriangleDimensionTwo)) || TriangleDimensionTwo < 1);

                        do
                        {
                            Console.Write("Enter 3rd dimension of triangle :-  ");
                        } while ((!int.TryParse(Console.ReadLine(), out TriangleDimensionThree)) || TriangleDimensionThree < 1);


                        if (TriangleDimensionOne + TriangleDimensionTwo > TriangleDimensionThree && TriangleDimensionOne + TriangleDimensionThree > TriangleDimensionTwo && TriangleDimensionTwo + TriangleDimensionThree > TriangleDimensionOne)
                        {
                            string result = TriangleSolver.Analyze(TriangleDimensionOne, TriangleDimensionTwo, TriangleDimensionThree);
                            Console.WriteLine(result);
                            Console.WriteLine("----------------------------------");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Dimension is not Valid...!!! Try Again ");
                            Console.WriteLine("----------------------------------");
                            break;
                        }
                        case 2:
                        Environment.Exit(0);
                        break;

                }
            } while (true);
        }
    }
}