using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crypta_lab_1
{
    public class TextPrepearing
    {

        public static string Parse(string path)
        {
            return System.IO.File.ReadAllText(path, Encoding.Default);
        }
       
        public static string Remove_Nonlaters(string text, out int space_count) 
        {
            text = text.Replace("ё", "е").Replace("'",string.Empty);

            Regex BadChars = new Regex("[^а-я ]");
            space_count = BadChars.Replace(text, "").Length;
            text = text.Replace(" ", "");

            return BadChars.Replace(text, "").ToLower(); 
        }

        public static string Remove_Nonlaters(string dirty_text, out int space_count,string trash)
        {
            var temp = dirty_text.Replace("ё", "е");
            //space_count = BadChars.Replace(text, "").Length;
            temp = Regex.Replace(temp, @"\s+", " ");
            temp = temp.Replace(" ", "_");
            var clean = Regex.Replace(temp, "[^а-я_]", "");
            space_count = clean.Length;
            var final = Regex.Replace(clean, "[^а-я]", "");

            return clean.ToLower();
        }

        public static string Remove_Nonlaters(string dirty_text,bool space)
        {
            var temp = dirty_text.Replace("ё", "е").Replace(" ", "_").ToLower();

            if (space) return Regex.Replace(temp, "[^а-я_]", "");
            else return Regex.Replace(temp, "[^а-я]", "");
        }
    }
}



