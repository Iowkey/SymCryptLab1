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

        public static void Displaying(Dictionary<string,double> lst)
        {
            foreach (var val in lst)
                Console.WriteLine($"{val.Key} = {val.Value} ");

            Console.WriteLine($"\nCount = {lst.Count}");
        }

        public static void Displaying(Dictionary<char, double> lst)
        {
            foreach (var val in lst)
                Console.WriteLine($"{val.Key} = {val.Value} ");
            Console.WriteLine($"\nCount = {lst.Count}");
        }

        public static List<char> Alphabet(string language)
        {
            var lst = new List<char>();

            if(language.Equals("Russian"))
            {
                for (int i = 1072; i <= 1103; i++)
                    lst.Add(Convert.ToChar(i));
                return lst;
            }
            else if (language.Equals("English"))
            {
                for (int i = 97; i <= 122; i++)
                    lst.Add(Convert.ToChar(i));
                return lst;
            }

            return null;            
        }

      
    }
}
