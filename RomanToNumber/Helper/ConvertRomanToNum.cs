using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using RomanToNumber.Model;

namespace RomanToNumber.Helper
{
    public class ConvertRomanToNum
    {
        private static bool IsRoman(string romanText)
        {
            //check text is roman
            string pattern = "^(M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})|[IDCXMLV]-)$";
            if (Regex.IsMatch(romanText, pattern)) return true;
            return false;
        }

        public static int ConvertToNum(string romanText)
        {
            if (!IsRoman(romanText)) throw new Exception("Roman text is not valid. Plz type other value");
            //init roman value
            var dataRoman = new List<RomanNumber>() {
                new RomanNumber() { RomanText = 'I', Number = 1 },
                new RomanNumber() { RomanText = 'V', Number = 5 },
                new RomanNumber() { RomanText = 'X', Number = 10 },
                new RomanNumber() { RomanText = 'L', Number = 50 },
                new RomanNumber() { RomanText = 'C', Number = 100 },
                new RomanNumber() { RomanText = 'D', Number = 500 },
                new RomanNumber() { RomanText = 'M', Number = 1000 }
            };

            List<int> numConvert = new List<int>();
            foreach (var rmt in romanText)
            {
                numConvert.Add(dataRoman.Find(x => x.RomanText.Equals(rmt)).Number);
            }
            for (int num = 0; num < numConvert.Count - 1; num++)
            {
                //check next value lager than current value
                if (numConvert[num] < numConvert[num + 1])
                {
                    //sum of current value and next value equal next value minus curent value
                    numConvert[num] = 0 - numConvert[num];
                    //ignore check next value
                    num++;
                }
            }

            return numConvert.Sum();
        }
    }
}