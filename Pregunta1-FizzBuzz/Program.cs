using System;
using System.Collections.Generic;
using System.Runtime;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1_FizzBuzz
{
    class Program
    {        
        static void Main(string[] args)
        {            
            run();                       
        }


        public static void run()
        {
            List<int> intList = new List<int>();
            PopulateList(ref intList);
            ScrPrnt(intList);
            Console.WriteLine("Pulsa una tecla para salir");
            Console.ReadKey();

        }

        private static void PopulateList(ref List<int>intList)
        {
            for (int i = 0; i <= 99; i++) {
                intList.Add(i);
            }
        }

        private static void ScrPrnt(List<int> intList)
        {
            foreach ( int i in intList)
            {
                if (i%3==0 && i%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i%3==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}
