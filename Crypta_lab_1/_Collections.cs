using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Crypta_lab_1
{
    public class _Collections
    {
        public static void Displaying(List<char> lst)
        {
            foreach (var val in lst)
                Console.Write($"{val} ");
            Console.WriteLine($"\nCount = {lst.Count}");
        }

        public static void Displaying(Dictionary<string,int> lst)
        {
            foreach (var val in lst)
                Console.WriteLine($"{val.Key} = {val.Value} ");

            Console.WriteLine($"\nCount = {lst.Count}");
        }

        public static void Displaying(Dictionary<char, int> lst)
        {
            foreach (var val in lst)
                Console.WriteLine($"{val.Key} = {val.Value} ");
            Console.WriteLine($"\nCount = {lst.Count}");
        }

        public static List<char> Alphabet(string language)
        {
            var lst = new List<char>();

            switch (language)
            {
                case "Russian":
                    {
                        for (int i = 1072; i <= 1103; i++)
                            lst.Add(Convert.ToChar(i));
                        return lst;
                    }
                case "English":
                    {
                        for (int i = 97; i <= 122; i++)
                            lst.Add(Convert.ToChar(i));
                        return lst;
                    }
            }
            return null;
            
        }

        //public static Dictionary<string ,int> Bigrams(string language)
        //{
        //    var alphabet = Alphabet(language);
        //    var Allbigrams = new Dictionary<string, int>();
            
        //    for (int i = 0; i < alphabet.Count; i++)
        //        for (int j = 0; j < alphabet.Count; j++)
        //            Allbigrams.Add( $"{alphabet[i]}" + $"{alphabet[j]}",0);

        //    return Allbigrams;       
                
        //}
    }
}
