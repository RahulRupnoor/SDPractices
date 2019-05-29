using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Program
    {
        public static void Main()
        {
            char[] input1 = new char[10];
            for (int i = 0; i < input1.Length; i++)
            {
             input1[i]= Convert.ToChar(Console.Read());
             Console.Write(input1.Count());
            }
            
            

            Console.ReadKey();
        }
    }
}
