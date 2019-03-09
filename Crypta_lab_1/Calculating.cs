using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
//using SautinSoft.Document;
using System.Text.RegularExpressions;

namespace Crypta_lab_1
{
    class Calculating
    {
        public static  double Entropy(double[] frec)
        {
            double sum = 0;

            for (int i = 0; i < frec.Length; i++)
                sum += -frec[i] * Log(frec[i],2);

            return sum;
        }

        public static Dictionary<char, double> MonogarmsVal(string path,string language)
        {

            string text1;
            if (language.Equals("English"))
                text1 = TextPrepearing.Remove_Nonlaters2(TextPrepearing.ParseText(path));
            else if (language.Equals("Russian"))
                text1 = TextPrepearing.Remove_Nonlaters1(TextPrepearing.ParseText(path));
            else text1 = null;

            var alphabet = _Collections.Alphabet(language);
            var monograms = new Dictionary<char, double>();

            foreach (char c in alphabet)
                monograms.Add(c, 0);

            foreach (char x in text1)
                monograms[x]++;

            monograms = monograms.ToDictionary(kvp => kvp.Key, kvp => kvp.Value / text1.Length);

            //sort by descending;
            monograms = monograms.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); 


            return monograms;
        }

        public static Dictionary<string,double> BigramVal(string path, string language)
        {
            string text1;
            if (language.Equals("English"))
                text1 = TextPrepearing.Remove_Nonlaters2(TextPrepearing.ParseText(path));
            else if (language.Equals("Russian"))
                text1 = TextPrepearing.Remove_Nonlaters1(TextPrepearing.ParseText(path));
            else text1 = null;


            var allbigrams = Bigrams.AllBigrams(_Collections.Alphabet(language));
            var bigrams = new Dictionary<string, double>();

            foreach (string x in allbigrams)
                bigrams.Add(x, 0);
           
            for (int i = 0; i < text1.Length - 1; i++)
                bigrams[$"{text1[i]}" + $"{text1[i + 1]}"]++;

                bigrams = bigrams.ToDictionary(kvp => kvp.Key, kvp => kvp.Value / text1.Length);

            //sort by descending;
            bigrams = bigrams.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); 

            return bigrams;
        }



        public static Dictionary<string, double> Frequency(Dictionary<string,int> BigramValue,string path,string language)
        {
            var Frequency = new Dictionary<string, double>();

            

            return null;


        }
    }
}
