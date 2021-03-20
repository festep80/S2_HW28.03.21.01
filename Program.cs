//1. Створити програму, яка вводить з клавіатури символи(посимвольно- Console.Read())
// та перетворює малі букви у великі та навпаки.

using System;

namespace S2_HW28._03._21._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter letter (0 - exit):");
            char v = '1';
            while(v!='0')
            {                
                v = (char)Console.Read();
                LetterCaseConvert(v);                
            }          
        }

        private static void LetterCaseConvert(char v)
        {
            if(Char.IsLower(v) == true)
            {
                Console.Write(Char.ToUpper(v));
            }
            else
            {
                Console.Write(Char.ToLower(v));
            }
        }
    }
}
