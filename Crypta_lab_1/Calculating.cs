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
       
        public static double Entropy(Dictionary<char, double> dict)
        {
            double H1 = 0;
            foreach (KeyValuePair<char, double> item in dict)
                if (item.Value != 0)
                    H1 += (-1) * item.Value * Log(item.Value, 2);
            
            return H1;
        }

        public static double Entropy(Dictionary<string, double> dict)
        {
            double H2 = 0;
            foreach (KeyValuePair<string, double> item in dict)
                if (item.Value != 0)
                    H2 += (-1) * item.Value * Log(item.Value, 2);

            return H2/2;
        }

        public static void Check(Dictionary<string, double> dict)
        {
            double sum = 0;
            foreach (KeyValuePair<string, double> item in dict)
                    sum += item.Value;
              
            Console.WriteLine($"Sum bigrams's freq  = {sum}");

        }
        public static void Check(Dictionary<char, double> dict)
        {
            double sum = 0;
            foreach (KeyValuePair<char, double> item in dict)
                    sum += item.Value;

            Console.WriteLine($"Sum monogram's  freq  = {sum}");
        }
        

        public static Dictionary<char, double> MonogarmsFrequency(string path,bool spaces)
        {
            int SpaceCount;
            var cleartext = TextPrepearing.Remove_Nonlaters(TextPrepearing.Parse(path), out SpaceCount,"");
            //
            Console.WriteLine($"/nSpaceCout = {SpaceCount} ClearText = {cleartext.Length}");
            //
            var alphabet = Ngrams.Alphabet(spaces);
            var monograms = new Dictionary<char, double>();

            foreach (char c in alphabet)
                monograms.Add(c, 0);

            foreach (char x in cleartext)
                monograms[x]++;
            
            var final_lenght = spaces ? SpaceCount : cleartext.Length;
            monograms = monograms.ToDictionary(kvp => kvp.Key, kvp => kvp.Value / final_lenght);

            return monograms.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); ;
        }

        public static Dictionary<string,double> BigramFrequancy(string path,bool touchable,bool spaces) 
        {
            int SpaceCount;
            var cleartext = TextPrepearing.Remove_Nonlaters(TextPrepearing.Parse(path), out SpaceCount);

            var allbigrams = Ngrams.AllBigrams(spaces);
            var bigrams = new Dictionary<string, double>();

            foreach (string x in allbigrams)
                bigrams.Add(x, 0);

            if (touchable)
                for (int i = 0; i < cleartext.Length - 1; i++)
                    bigrams[$"{cleartext[i]}" + $"{cleartext[i + 1]}"]++;
            else
                for (int i = 0; i < cleartext.Length - 1; i += 2)
                    bigrams[$"{cleartext[i]}" + $"{cleartext[i + 1]}"]++;
         
            var final_lenght = spaces ? SpaceCount : cleartext.Length;
            bigrams = bigrams.ToDictionary(kvp => kvp.Key, kvp => kvp.Value / final_lenght);

            return bigrams.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); ;
        }     
    }
}


     
