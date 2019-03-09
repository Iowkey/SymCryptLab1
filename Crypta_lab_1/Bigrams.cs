using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypta_lab_1
{
    class Bigrams
    {
        //creates all possible pairs of the entered alphabet;
        public static List<string> AllBigrams(List<char> alphabet) 
        {       
            var allbigrams = new List<string>(alphabet.Count * alphabet.Count);

            for (int i = 0; i < alphabet.Count; i++)
                for (int j = 0; j < alphabet.Count; j++)
                    allbigrams.Add($"{alphabet[i]}" + $"{alphabet[j]}");

            return allbigrams;
        }

        public static float UntouchebleBiGramsFrequency(string a)
        {
            string[] alphabet = Alphabet();
            float count = 0;
            int help = 0;
            string[] allbigrams = new string[31 * 31];
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    allbigrams[help] = $"{alphabet[i]}" + $"{alphabet[j]}";
                    Console.WriteLine(allbigrams[help]);
                    help += 1;
                }
            }
            for (int k = 0; k < allbigrams.Length; k++)
            {
                for (int l = 0; l < a.Length - 1; l += 2)
                {
                    if (($"{a[l]}" + $"{a[l + 1]}").Equals(allbigrams[k]))
                        count += 1;
                }
                Console.WriteLine($"Bigram {allbigrams[k]} frequency: {count / (a.Length - 1)}");
                count = 0;
            }
            return 0;
        }

    }
}
