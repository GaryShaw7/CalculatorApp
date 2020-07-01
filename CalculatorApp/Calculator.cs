using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class frmScreen1 : Form
    {
        public frmScreen1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            string data;



            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);

            if (rdoAdd.Checked)
            {
                result = add(num1, num2);
            }
            else if (rdoSubtract.Checked)
            {
                result = subtract(num1, num2);

            }else if (rdoMultiply.Checked)
            {
                result = multiply(num1, num2);
            }
            else
            {
                result = (int)divide(num1, num2);
            }

            lblResult.Text = result.ToString();

        }

            private int add(int num1, int num2)
            {
                return num1 + num2;
            }
        private int subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        private int multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        private double divide(int num1, int num2)
        {
            return (double)num1 / num2;
        }



    }
    }

