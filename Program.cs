using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char checkChar = Convert.ToChar(Console.ReadLine());
            RussianAlph russian = new RussianAlph(null, null);
            //russian.GetTextExample();
            //russian.GetAlph();
            russian.CheckChar(checkChar);
            Console.ReadKey();
        }
    }
}
