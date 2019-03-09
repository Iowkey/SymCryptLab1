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
        public static string ParseText(string path)
        {
            var text = System.IO.File.ReadAllText(path, Encoding.Default);
            return text.ToLower();
        }

        //using for Russian language;
        public static string Remove_Nonlaters1(string text) 
        {

            text = text.Replace("ё", "е").Replace("'",string.Empty);
            Regex.Replace(text, @"[^\x20-\x7F]", "");
            Regex BadChars = new Regex("[^а-я']");
            return BadChars.Replace(text, string.Empty);
        }

        //using fo English language;
        public static string Remove_Nonlaters2(string text) 
        {
            text = text.Replace("'", string.Empty);
            Regex.Replace(text, @"[^\x20-\x7F]", "");
            Regex BadChars_with_spaces = new Regex("[^a-z']"); //
            return BadChars_with_spaces.Replace(text, string.Empty);
        }


            
    }

                
}
