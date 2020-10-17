using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler10
{
    class Program   //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    {               //Find the sum of all the primes below two million.
        static void SumOfPrimesBelow(int bound)
        {
            List<int> primeNumbers = new List<int>();
            int result = 0;
            bool isPrime = true;
            for (int i = 2; i <= bound; i++)
            {
                for(int j = 0; j < primeNumbers.Count && isPrime == true; j++)
                {
                    isPrime = !(i > primeNumbers[j] && i % primeNumbers[j] == 0);
                }
                Console.WriteLine("i=" + i + "  isPrime=" + isPrime + "primeNumbers count=" + primeNumbers.Count);
                if (isPrime == false)
                {
                    isPrime = true;
                    continue;
                }
                primeNumbers.Add(i);
                result += i;
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            SumOfPrimesBelow(10);
            Console.ReadKey();
        }
    }
}
/*            for (int i = 2; i <= bound; i++)
            {
                for(int j = 0; j < primeNumbers.Count && isPrime == true && i > primeNumbers[j]; j++)
                {
                    if(i % primeNumbers[j] == 0)
                    {
                        isPrime = false;
                    }
                }
                Console.WriteLine("i=" + i + "  isPrime=" + isPrime + "primeNumbers count=" + primeNumbers.Count);
                if (isPrime == false)
                {
                    isPrime = true;
                    continue;
                }
                primeNumbers.Add(i);
                result += i;
            }*/
