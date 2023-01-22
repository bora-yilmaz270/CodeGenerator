using System;
using System.Linq;

namespace CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n 8 hane uzunluğunda ve unique olan kodlar üretilip sonrasında kontrol algoritmasına gönderiliyor.\n");
            for (int i = 0; i < 1000; i++)
            {
                var code = CodeProcess.GenerateCode();
                var isvalid = CodeProcess.CheckCode(code);
                Console.WriteLine(code + " is valid : " + isvalid);
            }

            Console.WriteLine("\n Test amaçlı yanlış kodlar üretilip sonrasında kontrol algoritmasına gönderiliyor. \n");
            for (int i = 0; i < 1000; i++)
            {
                var code = CodeProcess.GenerateWrongCode();
                var isvalid = CodeProcess.CheckCode(code);
                Console.WriteLine(code + " is valid : " + isvalid);
            }
        }

       
    }
}
