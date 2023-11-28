using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace CalculatorPrivateAssembly
{
    public partial class FrmBasicCalcu : Form
    {
        public FrmBasicCalcu()
        {
            InitializeComponent();
        }

        float num1, num2;

        private void FrmBasicCalcu_Load(object sender, EventArgs e)
        {
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);

            if (cbOperator.Text == "+")
            {
                textBox3.Text = BasicComputation.Addition(num1, num2).ToString();
            }else if (cbOperator.Text == "-")
            {
                textBox3.Text = BasicComputation.Subtraction(num1, num2).ToString();
            }else if (cbOperator.Text == "*")
            {
                textBox3.Text = BasicComputation.Multiplication(num1, num2).ToString();
            }else if (cbOperator.Text == "/")
            {
                textBox3.Text = BasicComputation.Division(num1, num2).ToString();
            }
        }
    }
}
