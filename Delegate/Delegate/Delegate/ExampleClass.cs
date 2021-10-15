using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace Delegate
{
    public delegate void ProcessNumber(int number);
    class ExampleClass
    {
        public int MultiplyNumbers(int a, int b, ProcessNumber pn)
        {
            int op = a * b;
            pn(op);
            return op;
        }
        public void DisplayNumber(int num)
        {
            MessageBox.Show(string.Format("The value is  {0}", num)); 
        }
    }
}
