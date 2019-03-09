using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypta_lab_1
{
    public class Monograms
    {

        //    public static char[] Allmonograms(string language)
        //    {
        //        char ch;
        //        int n = 0;

        //        switch (language)
        //        {
        //            case "Russian":
        //                {
        //                    char[] mass = new char[32];
        //                    for (int i = 1072; i <= 1103; i++)
        //                    {
        //                        ch = Convert.ToChar(i);
        //                        mass[n] = ch;
        //                        n++;
        //                    }
        //                    return mass;
        //                }
        //            case "English":
        //                {
        //                    char[] mass = new char[32];
        //                    for (int i = 97; i <= 122; i++)
        //                    {
        //                        ch = Convert.ToChar(i);
        //                        mass[n] = ch;
        //                        n++;
        //                    }
        //                    return mass;
        //                }

        //        }
        //        return null;
        //    }
        //    public static double[] Counts(string text, char[] mass)
        //    {
        //        double[] counts = new double[32];
        //        for (int i = 0; i < text.Length; i++)
        //            for (int j = 0; j < mass.Length; j++)
        //                if (text[i] == mass[j])
        //                    counts[j]++;
        //        return counts;
        //    }
        //    public static double[] Frequency(string text, double[] counts)
        //    {
        //        double[] frequency = new double[32];
        //        for (int i = 0; i < counts.Length; i++)
        //            frequency[i] = counts[i] / text.Length;

        //        return frequency;
        //    }
        //    public static void DisplayInfo(char[] aplhabet, double[] counts, double[] frequency)
        //    {

        //        Console.WriteLine("\n\t\t\t      M O N O G R A M S\n");
        //        for (int i = 0; i < aplhabet.Length; i++)
        //            Console.WriteLine($"\t\t| symbol = {aplhabet[i]} | count = {counts[i]} | frequency = {frequency[i]:0.00} |" );
        //    }
        //}
    }
}
