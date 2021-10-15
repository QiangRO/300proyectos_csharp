using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixProgram
{
    class Stack
    {
        public int Top { get; set; }
        char[] stck = new char[10];

        public void Push(char ch)
        {
            stck[++Top] = ch;
        }

        public char Pop(bool Remove)
        {
            char m = stck[Top];
            if (Remove)
            {
                Top--;
            }
            return m;
        }
    }
}
