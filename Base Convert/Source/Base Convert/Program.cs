using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baseConvert
{
    class Program
    {
        static string reverse(string input)
        {
            int length;
            string reversed = "";
            
            char[] chars = input.ToCharArray();
            length = chars.Length;

            for (int i = length; i > 0; i--)
                reversed += chars[i-1];

            return reversed;
        }

        static string convertBase(double number, byte targetBase)
        {
            string[] numbers = new string[36] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string convertedNumber = "";
            byte copy;

            while (number > 0)
            {
                copy = (Byte)(number % (Double)targetBase);
                convertedNumber += numbers[copy];
                number = (number - (Double)copy) / (Double)targetBase;
            }

            convertedNumber = reverse(convertedNumber);
            return convertedNumber;
        }
        
        
        static void Main(string[] args)
        {
            byte targetBase;
            double number;
            string convertedNumber, convertAgain;
            
            do
            {
                do
                {
                    Console.Write("Please enter a positive number in base 10 : ");
                    number = Convert.ToDouble(Console.ReadLine());
                    if (number < 0)
                        Console.WriteLine("Unable to convert negative numbers , please try again\n");
                } while (number < 0);

                do
                {
                    Console.Write("\nPlease enter a number between 2 and 36 as target base : ");
                    targetBase = Convert.ToByte(Console.ReadLine());
                    if (targetBase < 2 || targetBase > 36)
                        Console.WriteLine("Wrong target base, please try again");
                } while (targetBase < 2 || targetBase > 36);

                convertedNumber = convertBase(number, targetBase);
                Console.WriteLine("\n{0} in base 10 equals to {1} in base {2}", number, convertedNumber, targetBase);


                Console.WriteLine("\nConvert another number ? (Y/N)");
                convertAgain = Console.ReadLine();
                convertAgain = convertAgain.ToUpper();
                if (convertAgain != "Y" && convertAgain != "N")
                    do
                    {
                        Console.WriteLine("\nInvalid input , please try again , Convert another number ? (Y/N)");
                        convertAgain = Console.ReadLine();
                        convertAgain = convertAgain.ToUpper();
                    } while (convertAgain != "Y" && convertAgain != "N");

            } while (convertAgain == "Y");

        }
    }
}
