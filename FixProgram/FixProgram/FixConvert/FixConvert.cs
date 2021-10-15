using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FixExpression
{
    public partial class FixConvert 
    {

        public string Infix2Postfix(string Expression)
        {
            try
            {
                Stack<char> stk = new Stack<char>();
                string Exp = "";
                char CurrentChar;
                for (int i = 0; i < Expression.Length; i++)
                {
                    CurrentChar = Expression[i];
                    if (this.IsOprand(CurrentChar))
                    {
                        Exp += CurrentChar;
                        continue;
                    }

                    if (stk.Count == 0 || CurrentChar == '(')
                    {
                        stk.Push(CurrentChar);
                        continue;
                    }

                    int c = this.GetPriority(CurrentChar);
                    int o = this.GetPriority(stk.Peek());

                    while (c <= o)
                    {
                        Exp += stk.Pop();

                        if (stk.Count > 0)
                        {
                            o = this.GetPriority(stk.Peek());
                            if (o == 2)
                            {
                                stk.Pop();
                                break;
                            }
                            continue;
                        }
                        break;
                    }

                    if (CurrentChar != ')')
                    {
                        stk.Push(CurrentChar);
                    }
                }

                while (stk.Count != 0)
                {
                    Exp += stk.Pop();
                }
                return Exp;
            }
            catch
            {
                return "Error";
            }
        }

        public string Infix2Prefix(string Expression)
        {
            try
            {
                Stack<string> stk = new Stack<string>();
                string Exp = this.GetParenthesis(Expression);

                for (int i = 0; i < Exp.Length; i++)
                {
                    stk.Push(Exp[i].ToString());
                    if (stk.Peek() == ")")
                    {
                        stk.Pop();
                        string t1 = stk.Pop();
                        string t2 = stk.Pop();
                        string t3 = t2 + stk.Pop() + t1;
                        stk.Pop();
                        stk.Push(t3);
                    }
                }
                return stk.Pop();

            }
            catch
            {
                return "Error";
            }
        }

        public string Postfix2Infix(string PostfixExpression)
        {
            try
            {
                Stack<string> stk = new Stack<string>();
                char CurrentChar;
                for (int i = 0; i < PostfixExpression.Length; i++)
                {
                    CurrentChar = PostfixExpression[i];
                    if (this.IsOprand(CurrentChar))
                    {
                        stk.Push(CurrentChar.ToString());
                        continue;
                    }
                    string t1 = stk.Pop();
                    string t2 = stk.Pop();
                    string t3 = t2 + CurrentChar + t1;
                    stk.Push("(" + t3 + ")");
                }
                return stk.Pop();
            }
            catch
            {
                return "Error";
            }
        }

        public string Prefix2Infix(string PrefixExpression)
        {
            try
            {
                Stack<string> stk = new Stack<string>();
                char CurrentChar;
                int op = 0;
                for (int i = 0; i < PrefixExpression.Length; i++)
                {
                    CurrentChar = PrefixExpression[i];
                    stk.Push(CurrentChar.ToString());
                    if (!IsOprand(CurrentChar))
                    {
                        op = 0;
                        continue;
                    }

                    op++;
                    while (op == 2)
                    {
                        string t1 = stk.Pop();
                        string t2 = stk.Pop();
                        string t3 = "(" + t2 + stk.Pop() + t1 + ")";

                        if (stk.Count == 0)
                        {
                            return t3;
                        }

                        if (IsOprand(stk.Peek()))
                        {
                            op++;
                        }
                        stk.Push(t3);
                        op--;
                    }
                }
                //Don't Use
                return "Error";
            }
            catch
            {
                return "Error";
            }
        }
      
        public string GetParenthesis(string Expression)
        {
            return this.Postfix2Infix(this.Infix2Postfix(Expression));
        }

    }
}
