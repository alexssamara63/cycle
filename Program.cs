using System;
using System.Collections.Generic;

namespace cycle
{
    class Program
    {
       static void Main(string[] args)
       {
            long[] collection = new long[15];
            long sum = 0;
            long multiplication = 1;
            var i = 0;
            var y = 0;
            var z = 0;
            var x = 0;
            for (; i < 15; i++) 
              {
                long a = (long)Convert.ToInt32(Console.ReadLine());
                collection[i] = a;
              }
                for (; y < 15; y++)
                {
                  sum += collection[y];
                }
                  do
                  {
                    multiplication *= collection[z];
                    z++;
                  }
                  while (z < 15);
                         
                    long difference = collection[0] + collection[0];
                    while (x < 15)
                    {
                     difference -= collection[x];
                     x++;
                    }
              Console.WriteLine($"Сумма всех чисел массива = {sum}");
              Console.WriteLine($"Произведение всех чисел массива = {multiplication}");
              Console.WriteLine($"Разность всех чисел массива = {difference}");
                   foreach (var a in collection)
                   {
                      Console.WriteLine(a);
                   }
            Console.ReadLine();
       }

    }
}
