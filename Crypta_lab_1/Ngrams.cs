﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Crypta_lab_1
{
    public class Ngrams
    {
        public static void Display(List<char> lst)
        {
            foreach (var val in lst)
                Console.Write($"{val} ");
        }
        
        public static void Display(Dictionary<string,double> lst)
        {
            foreach (var val in lst)
                Console.WriteLine($"{Math.Round(val.Value,4)} ");
        }

        public static void Display(Dictionary<char, double> lst)
        {
            foreach (var val in lst)
                Console.WriteLine($"{val.Key} = {Math.Round(val.Value, 4)} ");
        }

        public static List<char> Alphabet(bool space)
        {
            var lst = new List<char>();

            for (int i = 1072; i <= 1103; i++)
                lst.Add(Convert.ToChar(i));

            if (space)
                lst.Add('_');
            
            return lst;
        }

        public static List<string> AllBigrams(bool space)
        {
            List<char> alphabet = Alphabet(space);
            var allbigrams = new List<string>(alphabet.Count * alphabet.Count);

            for (int i = 0; i < alphabet.Count; i++)
                for (int j = 0; j < alphabet.Count; j++)
                    allbigrams.Add($"{alphabet[i]}" + $"{alphabet[j]}");

            return allbigrams;
        }
    }
}
          

            
