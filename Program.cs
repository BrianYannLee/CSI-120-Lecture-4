//Programmer: Brian Lee
//Date: 04/17/2024

//Title: CSI 120 Lecture 4 Notes
using System.Threading.Channels;

namespace CSI_120_Lecture_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempConversion();
            IntandDouble();
            ParsingString();
            PICalcluation();
            ErrorHandling();

            /*Questions:
             * 1. What is the two primary flating-points type in C#:There is actually 3 flaoting type. Float, Double and Decimal
             * 2. What is the difference between float and double in C#: The main difference between float and double is the size and range. Double has larger range and size than a float
             * 3. Why is it generally recommended to use double instead of float for flating-point arithmetic? Like said, before the difference is the size and range. This would result in higher precision and less error prone when using a double
             * 4. How does C# represent floating-point number internally?: floating-point numbers are represented internally using the IEEE 754 standard, with the float type utilizing 32 bits and the double type utilizing 64 bits for storage.
             * 5. What are some common issues or consideration when performing arithmetic operation with floating-point numbers in C#:When working with floating-point you have to keep track on what are floating-point numbers and integral numbers when using them for calcuation. It may accidently convert between the who losing the accuracy of the results.
             */

        }//end of main
        public static void TempConversion()
        {
            Console.WriteLine("Temp Conversion");
            Console.WriteLine();
            
            Console.WriteLine("Please Input tempature in Celsius");
            float tempInput =float.Parse(Console.ReadLine());
            Console.WriteLine($"It is {tempInput*9/5+32}F degree");
            Console.WriteLine();

        }//end of TempConversion
        public static void IntandDouble()
        {
            Console.WriteLine("Int and Double");
            Console.WriteLine();

            int x = 5;
            double y = 5.5;

            int a = (int)(Math.Round(y));
            double b = (double)(x);

            Console.WriteLine($"Int Value {x} is converted to Float Value {b}");
            Console.WriteLine($"Int Value {y} is converted to Float Value {a}");
            Console.WriteLine();
        }//end of IntandDouble

        public static void ParsingString()
        {
            Console.WriteLine("Parsing String");
            Console.WriteLine();

            Console.WriteLine("Enter two integers.");
            int userInput1, userInput2;

            bool check1 = int.TryParse(Console.ReadLine(), out userInput1);
            bool check2 = int.TryParse(Console.ReadLine(), out userInput2);
            if(check1 == true && check2 == true)
            {
                Console.WriteLine($"The sum of {userInput1} and {userInput2} is {userInput1+userInput2}");
            }
            else
            {
                Console.WriteLine("Error has occured");
            }
            Console.WriteLine();
        }//end of ParsingString

        public static void PICalcluation()
        {
            Console.WriteLine("Pi Calculation");
            Console.WriteLine();

            Console.WriteLine("Please input the radius of the circle");
            string userInput = Console.ReadLine();

            int radiusInt = int.Parse(userInput);
            double radiusDub = double.Parse(userInput);

            Console.WriteLine($"The Area of the circle using int is {(Math.PI)*Math.Pow(radiusInt,2)}");
            Console.WriteLine($"The Area of the circle using double is {(Math.PI) * Math.Pow(radiusDub, 2)}");


            Console.WriteLine();
        }//end of Pi Calculation

        public static void Rounding()
        {
            Console.WriteLine("Rounding");
            Console.WriteLine();
            float userInput = float.Parse(Console.ReadLine());
            float answer = (float)Math.Round(userInput,2);


            Console.WriteLine();
        }//end of Rounding
        public static void ErrorHandling()
        {
            Console.WriteLine("ErrorHandling");
            Console.WriteLine();

            Console.WriteLine("Please input a decimal number");
            string userInput = Console.ReadLine();
            try
            {
                decimal num = decimal.Parse(userInput);
                Console.WriteLine($"You have entered: {num.ToString("C")}");
            }
            catch
            {
                Console.WriteLine("Error has occured");
            }

            Console.WriteLine();
        }//end of ErrorHandling

    }// end of class
}//end of namespace
