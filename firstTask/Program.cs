using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string resultString = "";
            for (int i = 1; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > stringArray[0].Length)
                {
                    stringArray[0] = stringArray[i];
                }
                
            }
            resultString = stringArray[0];
            Console.WriteLine("the longest world is: {0}", resultString);
            Console.ReadKey();
        }
    }
}
