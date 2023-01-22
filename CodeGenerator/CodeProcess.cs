using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    public static  class CodeProcess
    {
        /// <summary>
        ///2 farklı karakter setinden random olarak 8 hane uzunluğunda ve unique olan kodlar üreten method. 
        /// </summary>
        /// <returns></returns>
        public static string GenerateCode()
        {

            var firstCharSet = "ACDEFGHKLMNPRTXYZ234579";
            var secondCharSet = "BWSVUJQ168!@";

            Random rand = new Random();
            var result = new string(Enumerable.Repeat(firstCharSet, 4)
                .Select(s => s[rand.Next(s.Length)])
                .Take(4)
                .Concat(Enumerable.Repeat(secondCharSet, 4)
                    .Select(s => s[rand.Next(s.Length)])
                    .Take(4))
                .ToArray());
            return result;
        }

        /// <summary>
        ///2 farklı karakter setinden random olarak 8 hane uzunluğunda ve unique olan ve algoritmaya uymayan yanlış kodlar üreten method.
        /// </summary>
        /// <returns></returns>
        public static string GenerateWrongCode()
        {
            var firstCharSet = "BWSVUJQ168!@";
            var secondCharSet = "ACDEFGHKLMNPRTXYZ234579";
            Random rand = new Random();
            var result = new string(Enumerable.Repeat(firstCharSet, 4)
                .Select(s => s[rand.Next(s.Length)])
                .Take(4)
                .Concat(Enumerable.Repeat(secondCharSet, 4)
                    .Select(s => s[rand.Next(s.Length)])
                    .Take(4))
                .ToArray());
            return result;
        }

        /// <summary>
        /// Üretilen kodları kontrol eden method.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static bool CheckCode(string code)
        {
            if (code.Length != 8)
            {
                return false;
            }
            var firstCharSet = "ACDEFGHKLMNPRTXYZ234579";
            var secondCharSet = "BWSVUJQ168!@";
            var isGenerated = code.Take(4).All(c => firstCharSet.Contains(c)) && code.Skip(4).Take(4).All(c => secondCharSet.Contains(c));
            return isGenerated;
        }
    }
}
