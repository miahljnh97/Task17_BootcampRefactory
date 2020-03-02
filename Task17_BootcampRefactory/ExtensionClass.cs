using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Humanizer;

namespace Task17_BootcampRefactory
{
    public static class ExtensionClass 
    {
        public static string Capitalize(this string str1)
        {

            return Regex.Replace(str1, @"\b[a-z]\w+", delegate (Match match)
            {
                string v = match.ToString();
                return char.ToUpper(v[0]) + v.Substring(1);
            });
        }

        public static string SnakeCase(this string str1)
        {
            return Regex.Replace(str1, " ", "_");
        }
        
        public static string KebabCase(this string str1)
        {
            return Regex.Replace(str1, " ", "-");
        }

        public static T Mode<T>(this IEnumerable<T> value)
        {
            return value.GroupBy(q => q).OrderByDescending(q => q.Count()).Select(k => k.Key).First();
        }

        public static string Trim(this string str1, int number)
        {
            return $"{str1.Substring(0, number)}. . .";
        }

        public static string TrimWords(this string str1, int number)
        {
            return String.Join(" ", str1.Split(' ').Take(number));
        }

        public static string Convert(this int number)
        {
            string result = null;
            List<string> satuan = new List<string>()
            {
                "puluh", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan"
            };

            List<string> belasan = new List<string>()
            {
                "puluh", "se", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan"
            };

            if (number < 10)
            {
                result = satuan[number];
            }
            else if(number == 10)
            {
                result = "sepuluh";
            }
            else if(number == 11)
            {
                result = "sebelas";
            }
            else if(number % 10 == 0)
            {
                result = belasan[number / 10] + " puluh ";
            }
            else if(number > 10 && number < 20)
            {
                result = belasan[number % 10] + " belas";
            }
            else if(number > 20)
            {
                var puluhan = number.ToString().ToCharArray().First().ToString();
                var puluhanNumber = belasan[Int32.Parse(puluhan)] + " puluh ";
                var satuanNumber = satuan[number % 10];
                result = puluhanNumber + satuanNumber;
            }

            return result;
        }
    }
}