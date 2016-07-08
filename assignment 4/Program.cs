using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            Random end = new Random();
            int rnd = end.Next(1, 6);
            rnd = array[rnd];
            foreach (int s  in array)
            {
                
                Console.Write(s);     
            }
            
            for (int i = 1; i < array.Length; i++)
            {

                Console.WriteLine(rnd);
                
            }
            
        }
    }
}
