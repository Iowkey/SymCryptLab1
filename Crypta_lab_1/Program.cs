using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Crypta_lab_1
{
    class Program
    {        
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            //var path = @"C:\Users\nazar\source\repos\Crypta_FirstLab";

            //var H1 = Calculating.Entropy(Calculating.MonogarmsFrequency(path,false));
            //var H2 = Calculating.Entropy(Calculating.BigramFrequancy(path,true,true));
            //Console.WriteLine($"H1 = {H1}\nH2 = {H2}");

            //Calculating.Check(Calculating.MonogarmsFrequency(path, true));
            //Calculating.Check(Calculating.BigramFrequancy(path, true, false));
            //Console.WriteLine(TextPrepearing.Remove_Nonlaters(TextPrepearing.Parse(path),true));
            Export.ToExcel(@"C: \Users\nazar\source\repos\Crypta_FirstLab\Lab1.txt");
            watch.Stop();
            var elapsedMs = (double) watch.ElapsedMilliseconds;
            double sec = elapsedMs / 1000;
            Console.WriteLine($"\n\nEXECUTION TIME: {Math.Round(sec,2)} s");

            Console.WriteLine($"\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}