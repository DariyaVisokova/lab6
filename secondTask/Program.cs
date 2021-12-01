using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string startString = Console.ReadLine();
            string result;

            string reverseString = new string(startString.Reverse().ToArray());
            result = (reverseString == startString) ? "true" : "false";
            Console.WriteLine(reverseString);
            Console.WriteLine(result);
            Console.ReadKey();
        }

            
             
        
    }
}
