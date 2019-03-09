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


    }
}
