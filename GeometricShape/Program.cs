using System;
using System.Threading;

namespace GeometricShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop = amountLoop();

            for (int i = 0; i < loop; i++)
            {
                topOfTheShape(i);

                bodyOfTheShape(i);

                bottomOfTheShape(i);

                /** loop every 1 second **/
                Thread.Sleep(1000);
            }
        }

        private static int amountLoop()
        {
            Console.Write("Enter loop amount here: ");

            string inputLoop;
            inputLoop = Console.ReadLine();
            return Int32.Parse(inputLoop);
        }

        private static void topOfTheShape(int input)
        {
            string space = "";

            /** calculates how many spaces are needed before the '*'**/
            for (int i = input; i > 0; i--)
            {
                space = String.Concat(space, " ");
            }

            Console.WriteLine(String.Concat(space, "*"));
        }

        private static void bodyOfTheShape(int input)
        {
            int loops = input - 1;
            string space = "";
            string secondCalc = "";
            int calc2 = loops;
            int count = 0;

            /** loops 0 and 1 does not have a body, just top and bottom, so ignore**/
            if (input >= 2)
            {
                for (int i = 0; i < loops; i++)
                {

                    while(calc2 > 0)
                    {
                        for (int j = calc2; j > 0; j--) {
                            space = String.Concat(space, ' ');
                        }

                        string firstCalc = String.Concat( space, "*");

                        int[] arrayBody = ArrayBody(input);

                        for (int k = 0; k < arrayBody[count]; k++)
                        {
                            secondCalc = String.Concat(secondCalc, ' ');
                        }

                        string result = String.Concat(firstCalc, secondCalc, "*");

                        /** increment and reset variables **/
                        count++;
                        calc2--;
                        space = "";
                        secondCalc = "";

                        /** print the loop result **/
                        Console.WriteLine(result);
                    }
                }
            }
        }

        private static void bottomOfTheShape(int input)
        {
            string pyramidBase = "";

            /** inserts the set of '* '**/
            for (int i = input; i > 0; i--)
            {
                pyramidBase = String.Concat(pyramidBase, "* ");
            }

            /** inserts the last '*' **/
            if (input > 0)
            {
                pyramidBase = String.Concat(pyramidBase, "*");
            }

            Console.WriteLine(pyramidBase);
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private static int[] ArrayBody(int input) {

            int[] loop = new int[input];
            int arrayItem = 1;
            for (int runs = 0; runs < input; runs++)
            {
                loop[runs] = arrayItem;
                arrayItem += 2;
            }

            return loop;
        }
    }
}
