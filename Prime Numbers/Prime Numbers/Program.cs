using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prime_Numbers
{
    class Program
    {
        static ulong FindNextPrimeNumber(ulong[] array)
        {
            bool again;
            ulong testNumber;
            testNumber = array[array.Length - 1];

            do
            {
                again = false;
                testNumber += 2;

                foreach (ulong primeNumber in array)
                {
                    if (primeNumber*primeNumber > testNumber)
                        break;

                    if (testNumber % primeNumber == 0 && testNumber != primeNumber)
                    {
                        again = true;
                        break;
                    }

                }

            } while (again == true);
            return testNumber;
        }

        static ulong[] AddToArray(ulong number, ulong[] array)
        {
            ulong[] oldArray = array;
            array = new ulong[oldArray.Length + 1];
            oldArray.CopyTo(array, 0);
            array[oldArray.Length] = number;
            return array;
        }
        
        static void Main(string[] args)
        {
            ulong[] arrayOfPrimeNumbers = new ulong[2] {2, 3};
            string repeat = "N";
            ulong neededPrimeNumber, result;
            int arrayLength = 2;

            do
            {
                Console.Write("Please enter a number : ");
                neededPrimeNumber = Convert.ToUInt32(Console.ReadLine());

                while((ulong)arrayLength < neededPrimeNumber)
                {
                    ulong nextPrimeNumber = FindNextPrimeNumber(arrayOfPrimeNumbers);
                    arrayOfPrimeNumbers = AddToArray(nextPrimeNumber, arrayOfPrimeNumbers); //Error
                    arrayLength = arrayOfPrimeNumbers.Length;
                }

                result = arrayOfPrimeNumbers[neededPrimeNumber - 1];
                Console.WriteLine("\nThe {0}{1} prime number is {2}", neededPrimeNumber,
                                                                    neededPrimeNumber == 1 ? "st" : neededPrimeNumber == 2 ? "nd" : neededPrimeNumber == 3 ? "rd" : "th",
                                                                    result);
                Console.Write("\nFind another ? (Y/N) ");
                repeat = Console.ReadLine();
                Console.WriteLine();

                repeat = repeat.ToUpper();
                if (repeat != "Y" && repeat != "N")
                    do
                    {
                        Console.WriteLine("\nInvalid input , please try again , Find another ? (Y/N)");
                        repeat = Console.ReadLine();
                        repeat = repeat.ToUpper();
                    } while (repeat != "Y" && repeat != "N");

            } while (repeat == "Y");
        }
    }
}
