using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] split = line.Split(',');
            System.Console.WriteLine(countPrimes(int.Parse(split[0]), int.Parse(split[1])));
        }
    }

    public static int countPrimes(int m, int n)
    {
        int totalPrimes = 0;
        for (int i = m; i <= n; i++)
        {
            if (IsPrime(i))
            {
                totalPrimes++;
            }
        }
        return totalPrimes;
    }

    public static bool IsPrime(int n)
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
