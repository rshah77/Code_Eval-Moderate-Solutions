using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class RemoveCharacters
{
    static string[] splitString;
    static char[] oldString;
    static char[] charToCheck;

    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                splitString = line.Split(',');
                oldString = splitString[0].ToCharArray();
                charToCheck = splitString[1].Trim().ToCharArray();

                foreach (var inputItem in oldString) 
                {
                    if (!charToCheck.Contains(inputItem)) 
                    {
                        System.Console.Write(inputItem);
                    }
                }
                System.Console.WriteLine("");
            }
        }
    }
}
