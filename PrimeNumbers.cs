using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_5
{
    public class PrimeNumbers
    {
        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static IEnumerable<int> GetPrimes(int limit)
        {
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i))
                {
                    yield return i;
                }
            }
        }


        public static IEnumerable<int> GetAllPrimes()
        {
            for (int i = 2; ; i++)
            {
                if (IsPrime(i))
                {
                    yield return i;
                }
            }
        }


        public static IEnumerable<int> SkipPrimes(int count)
        {
            int skipped = 0;
            int num = 2;

            while (skipped < count)
            {
                if (IsPrime(num))
                {
                    skipped++;
                }
                num++;
            }

            for (int i = num; ; i++)
            {
                if (IsPrime(i))
                {
                    yield return i;
                }
            }
        }
    }
}
