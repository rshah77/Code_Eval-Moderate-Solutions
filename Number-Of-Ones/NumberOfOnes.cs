using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class NumberOfOnes
{
    static void Main(string[] args)
    {
         List<string> lines = new List<string>();
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                lines.Add(line);
                line = reader.ReadLine();
            }
        }
        
        for (int i = 0; i < lines.Count; i++)
        {
            int value = Convert.ToInt16(lines[i]);
            string binary = Convert.ToString(value, 2);
            int count = binary.Split('1').Length - 1;
            System.Console.WriteLine(count);
        }
    }
}
