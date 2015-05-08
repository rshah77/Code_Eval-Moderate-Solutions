using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class PrimeNumbers
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            PrimeNumbers(uint.Parse(line));
        }
    }

    public static void PrimeNumbers(uint number)
    {
        List<int> primeNumberList = new List<int>();

        for (uint i = 2; i < number; i++)
        {
            if (IsPrime(i))
            {
                primeNumberList.Add(int.Parse(i.ToString()));
            }
        }
        System.Console.WriteLine(String.Join(",", primeNumberList));
    }

    public static bool IsPrime(uint n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        int m = (int)System.Math.Sqrt(n);
        for (int i = 3; i <= m; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
