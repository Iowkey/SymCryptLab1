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
                sum += -frec[i] * (double) Log(frec[i],2);

            return sum;
        }

        public static Dictionary<char, int> MonogarmsVal(string path,string language)
        {

            string text1 = TextPrepearing.Remove_Nonlaters2(TextPrepearing.ParseText(path));   //for english;
           //string text1 = TextPrepearing.Remove_Nonlaters1(TextPrepearing.ParseText(path)); // for russian;
            var alphabet = _Collections.Alphabet(language);
            var monograms = new Dictionary<char, int>();

            foreach (char c in alphabet)
                monograms.Add(c, 0);

            foreach (char x in text1)
                monograms[x]++;

            //sort by descending;
            monograms = monograms.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); 


            return monograms;
        }

        public static Dictionary<string,int> BigramVal(string path, string language)
        {           
            string text1 = TextPrepearing.Remove_Nonlaters2(TextPrepearing.ParseText(path)); // for english;
            //string text1 = TextPrepearing.Remove_Nonlaters1(TextPrepearing.ParseText(path)); // for russian;

            var allbigrams = Bigrams.AllBigrams(_Collections.Alphabet(language));
            var bigrams = new Dictionary<string, int>();

            foreach (string x in allbigrams)
                bigrams.Add(x, 0);
           
            for (int i = 0; i < text1.Length - 1; i++)
                bigrams[$"{text1[i]}" + $"{text1[i + 1]}"]++;

            //sort by descending;
            bigrams = bigrams.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); 

            return bigrams;
        }
    }
}
