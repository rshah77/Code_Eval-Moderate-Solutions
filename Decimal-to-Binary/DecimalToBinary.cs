using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        
        string binary = "";
        using (StreamReader reader = File.OpenText(args[0]))
        {
            while (!reader.EndOfStream)
            {
                string[] numbers = reader.ReadLine().Split(',');
                foreach(var item in numbers)
                {
                    int value = Convert.ToInt32(item);
                    binary = Convert.ToString(value, 2);
                }
                System.Console.WriteLine(binary);
            }
        }
    }
}
