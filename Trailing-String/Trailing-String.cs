using System;
using System.Collections.Generic;
using System.IO;

class TrailingString
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\raj.shah\Desktop\numbers.txt";
        using (StreamReader reader = File.OpenText(path))
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
