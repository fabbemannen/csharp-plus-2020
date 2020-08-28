using System;
using System.Globalization;

namespace Session03Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatProvider format = CultureInfo.CurrentCulture;
            Console.WriteLine("Nuvarande språkinställning: " + CultureInfo.CurrentCulture.NativeName + "/" + CultureInfo.CurrentCulture.EnglishName);
            while (true)
            {
                Console.WriteLine("Ange ett antal siffror, separerat med mellanslag.");
                var input = Console.ReadLine();
                if (input != "")
                {
                    var inputArray = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var inputTotal = 0.0;
                    var inputLength = inputArray.Length;

                    foreach (var number in inputArray)
                    {
                        Console.Write("Värdet är " + number);
                        if (double.TryParse(number, out double numberParse))
                        {
                            inputTotal += Convert.ToDouble(numberParse);
                        }
                        else
                        {
                            //Error exception, wrong format
                            //Set color and then reset it after the error
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" ERROR: FORMAT EXCEPTION");
                            Console.ResetColor();
                            //Fix average (without removing the entry)
                            inputLength--;
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Total: " + inputTotal + " Average: " + Math.Round(inputTotal / (double)inputLength, 3));
                    Console.WriteLine();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
