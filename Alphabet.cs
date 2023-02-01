using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    internal abstract class Alphabet
    {
        public Alphabet(string alphName, char[] alph)
        {
        }

        public abstract void CheckChar(char charForCheck);
        public abstract void GetTextExample();
        public abstract void GetAlph();

    }
}
