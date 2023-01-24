using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();


            string lower = "abcdefghijklmnopqrstuvwxyz";
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string symbols = "[]{}()*;/,._-";

            int length = 16;
            string all = lower + upper + numbers + symbols;




            int i = 0;
            while (i < 1000)
            {

                var password = new string(all.OrderBy(x => Guid.NewGuid()).Take(length).ToArray());
                if (!set.Contains(password))
                {
                    set.Add(password);
                    Console.WriteLine(password);
                }
                i++;
            }

        }




    }
}
