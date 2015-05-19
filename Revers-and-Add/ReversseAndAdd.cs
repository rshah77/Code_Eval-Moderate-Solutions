using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            int n = int.Parse(reader.ReadLine());
                int number = 0;
                while (!isResultPlaindrome(n.ToString()) || n.ToString().Length <= 1)
                {
                    n += int.Parse(string.Join("", n.ToString().Reverse().Select(x => x.ToString()).ToArray<string>()));
                    number++;
                }
                System.Console.WriteLine(string.Format("{0} {1}", number, n));
        }
    }
    
    public static bool isResultPlaindrome(string Number)
    {
        //reverse string
        string reverseNum = string.Join("", Number.ToString().Reverse().Select(x => x.ToString()).ToArray<string>());
        if (Number == reverseNum)
        {
            return true;
        }
        return false;
    }
}
