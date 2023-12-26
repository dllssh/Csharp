using System;
using System.IO;

namespace Learn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string list = File.ReadAllText(@"C:\Users\user\Documents\GitHub\Csharp\Learn1\task1.txt");
            int length = 0;
            int max_length = 0;

            for(int i = 0; i < list.Length; i++)
            {
                if (list[i].ToString() == "A" || list[i].ToString() == "E")
                {
                    if(max_length < length)
                    {
                        max_length = length;
                    }
                    length = 0;
                }
                else
                {
                    length++;
                }
            }
            Console.WriteLine("Длина самой длинной подцепочки: " + max_length);
            Console.ReadKey();
        }
    }
}
