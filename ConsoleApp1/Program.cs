using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            string n1 = Console.ReadLine();
            int nn1 = change(n1);
            string n2 = Console.ReadLine();
            int nn2= change(n2);
            
            Console.WriteLine(nn1 + nn2);
            
            


            //Console.WriteLine("Hello World!"); 
        }


        public static int change(string valueAsString)
        {
            
            int valueAsNumber;
            bool isNumber = int.TryParse(valueAsString, out valueAsNumber);
            return valueAsNumber;
        }
    }
}
