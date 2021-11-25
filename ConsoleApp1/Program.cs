using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Te tog sa introduci dimensiunea vetorului: ");
            int dimensiuneVector = Convert.ToInt32(Console.ReadLine());
            int[] array = new int [dimensiuneVector];

            Console.WriteLine("Introdu elementele vectorului: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("--------------------------------");

            int sumaElemente = 0;
            int mediaElemente = 0;
            int contorPare = 0;
            int minim = 0;
            int maxim = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumaElemente += array[i];
                mediaElemente = sumaElemente / array.Length;
                if(array[i] % 2 == 0)
                { 
                    contorPare++;
                }
                minim = array[0];
                if (array[i] < minim)
                {
                    minim = array[i];
                }
                maxim = array[i];
                if(array[i] > maxim)
                {
                    maxim = array[i];
                }
            }
            Console.WriteLine("Suma este = " + sumaElemente);
            Console.WriteLine("Media este = " + mediaElemente);
            Console.WriteLine($"Sunt {contorPare} numere pare in vetorul dat.");
            Console.WriteLine($"Minumul vectorului este = {minim}");
            Console.WriteLine($"Maximul vectorului este = {maxim}");
        }
    }
}
