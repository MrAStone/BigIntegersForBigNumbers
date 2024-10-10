using System.Numerics;
namespace BigIntegersForBigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long largerInteger;
            
            BigInteger reallyBigInteger = 1;
            int n = 1000;

            for(int i =1; i <= n; i++)
            {
                reallyBigInteger = reallyBigInteger * i;
            }
            Console.WriteLine(reallyBigInteger.ToString());

        }
    }
}
