using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixExpression
{
    partial class FixConvert
    {
        protected bool IsOprand(char chr)
        {
            switch (chr)
            {
                case '^':
                case '+':
                case '-':
                case '*':
                case '/':
                case '(':
                case ')':
                    return false;
                default:
                    return true;
            }
        }

        protected bool IsOprand(string chr)
        {
            if (chr.Length > 1)
            {
                return true;
            }
            return IsOprand(char.Parse(chr));
        }

        protected int GetPriority(char chr)
        {
            switch (chr)
            {
                case ')':
                    return 1;
                case '(':
                    return 2;
                case '+':
                case '-':
                    return 3;
                case '*':
                case '/':
                    return 4;
                case '^':
                    return 5;
            }
            return 0;
        }
    }
}
