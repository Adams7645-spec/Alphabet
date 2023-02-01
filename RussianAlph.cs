using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal class RussianAlph : Alphabet
    {
        string alphName;
        string lineAlph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
                          "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        char[] alph;
        
        string[] textExemple = { "Этот текст написан на руссом языке",
                                 "Русский язык - один из сложнейших языков планеты",
                                 "Русский язык очень богат"};

        public RussianAlph(string alphName, char[] alph) : base(alphName, alph)
        {
            alphName = "Русский";
            this.alphName = alphName;
            alph = lineAlph.ToCharArray();
            this.alph = alph;
        }

        public override void CheckChar(char charForCheck)
        {
            int counter = 0;
            for (int i=0; i<alph.Length; i++)
            {
                if (charForCheck == alph[i])
                {
                    counter++;
                }
            }
            if (counter == 1) { Console.WriteLine("Символ есть в алфавите"); }
            else { Console.WriteLine("Символ отсутствует в алфавите"); }
        }

        public override void GetAlph()
        {
            for (int i=0; i<alph.Length; i++)
            {
                Console.Write($"{alph[i]} ");
            }
        }

        public override void GetTextExample()
        {
            Random GetRandom = new Random();
            Console.WriteLine($"{textExemple[GetRandom.Next(textExemple.Length)]}");
        }
    }
}
