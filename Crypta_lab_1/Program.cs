﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Crypta_lab_1
{
    class Program
    {        
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            //_Collections.Displaying()
            //_Collections.Displaying(Calculating.MonogarmsVal(@"C: \Users\temat\Desktop\Crypta\ff.txt", "English"));
            _Collections.Displaying(Calculating.BigramVal(@"C: \Users\temat\Desktop\Crypta\ff.txt", "English"));
            //_Collections.Displaying(_Collections.Alphabet("English"));
            //_Collections.Displaying(_Collections.Bigrams("English"));

            //Console.WriteLine($"{TextPrepearing.Remove_Nonlaters2(TextPrepearing.ParseText(@"C: \Users\temat\Desktop\Crypta\ff.txt"))}");

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine($"\n\nEXECUTION TIME: {elapsedMs}");

            Console.WriteLine($"\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
       



















//static double Sum(double[] frequency)
        //{
        //    double sum = 0;
        //    for (int q = 0; q < frequency.Length; q++)
        //        sum += frequency[q];

        //    return sum;
        //}