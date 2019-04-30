using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 2. store two variables  */
            Console.Write("Please enter your full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Please enter your location: ");
            string location = Console.ReadLine();

            /* 3. output  two writeLine */
            Console.WriteLine($"Your name is: { fullName }");
            Console.WriteLine($"Your location is: { location }");

            /* 4. Output current date not time */
            var date = DateTime.Now;
            Console.WriteLine($"The date is: { date.ToShortDateString() }");

            /* 5. Output number of days until christmas */ 
            var today = DateTime.Now;
            var christmas = new DateTime(2019, 12, 25);
            // TODO: calculate number of days until christmas
            var christmasCountDown = (christmas - today);
            Console.WriteLine($"Christmas is in { christmasCountDown.Days } days! ");

            /* 6. add program from book */
            /* 7. add requirements to code
             *  a. probived appropriate text lables */
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please enter Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
                woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                glassArea + " square metres");


            /* b.cause program to pause in console */

            Console.WriteLine("Press any key to exit");
            Console. ReadKey();
        }

    }
}
