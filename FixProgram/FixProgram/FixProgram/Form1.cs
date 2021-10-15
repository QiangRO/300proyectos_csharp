using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FixExpression;

namespace FixProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FixConvert fc = new FixConvert();
            lblP.Text = fc.GetParenthesis(textBox1.Text);
            lblIn2Post.Text = fc.Infix2Postfix(textBox1.Text);
            lblIn2Pre.Text = fc.Infix2Prefix(textBox1.Text);
            lblPost2In.Text = fc.Postfix2Infix(lblIn2Post.Text);
            lblPre2In.Text = fc.Prefix2Infix(lblIn2Pre.Text);
        }
    }
}
