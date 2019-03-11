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
       
        

        public static string Remove_Nonlaters(string dirty_text,bool space)
        {
            var temp = dirty_text.Replace("ё", "е").ToLower();
            temp = Regex.Replace(temp, @"\s+", "_");
            temp = temp.Replace("ъ", "ь");

            if (space) return Regex.Replace(temp, "[^а-я_]", "");
            else return Regex.Replace(temp, "[^а-я]", "");
        }
    }
}



