using System;
using System.Collections.Generic;
using System.IO;

class TrailingString
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] split = line.Split(',');
            if (split[0].EndsWith(split[1])) 
            {
                System.Diagnostics.Debug.WriteLine(1);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(0);
            }
        }
    }  
}
