using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calc : Form
    {
        string input = string.Empty;
        string num1 = string.Empty;
        string num2 = string.Empty ;
        char op = ' ';
        double answser = 0;



        public calc()
        {
            InitializeComponent();
        }

        public void UpdateText() //Check if we need to update textbox
        {
            if(String.IsNullOrEmpty(num1))
            {
                textBox.Text = answser.ToString();
            }
            else if(op == ' ')
            {
                textBox.Text = num1.ToString();
            }else if (String.IsNullOrEmpty(num2))
            {
                textBox.Text = '0' + ' ' + op + ' ' + num2.ToString();
            }
            else
            {
                textBox.Text = num2.ToString() + ' ' + op + ' ' + num1.ToString();
            }
            
            return;
        }

        public void EnterNumber(string input)
        {
            if(op == ' ')
            {
                num1 = num1 + input;
            }
            else
            {
                num2 = num2 + input;
            }
            UpdateText();
        }

        public void EnterOperation(char input)
        {
            if(op == ' ')
            {
                op = input;
            }else
            {
                PerformOperation(Convert.ToDouble(num1), Convert.ToDouble(num2), op);
            }
            UpdateText();
        }

        private void PerformOperation(double num1,double num2,char op)
        {
            switch (op)
            {
                case 'x':
                    return;
                case '+':
                    return;
                case '-':
                    return;
                case '/':
                    return;
                case '^':
                    return; 
                default: return;
            }
        }

        public void ClearCalc()
        {
            input = string.Empty;
            num1 = string.Empty;
            num2 = string.Empty;
            op = ' ';
            answser = 0;
            textBox.Text = "0";
            UpdateText();
        }

       



        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar) //Switch case for keyboard input
            {
                case (char)Keys.Back:
                    deleteButton.PerformClick();
                    break;
                case (char)Keys.Multiply:
                    multiButton.PerformClick();
                    break;
                case (char)Keys.Enter:
                    equalButton.PerformClick();
                    break;
                case (char)Keys.D0:
                    zeroButton.PerformClick();
                    break;
                case (char)Keys.D1:
                    oneButton.PerformClick();
                    break;
                case (char)Keys.D2:
                    twoButton.PerformClick();
                    break;
                case (char)Keys.D3:
                    threeButton.PerformClick();
                    break;
                case (char)Keys.D4:
                    fourButton.PerformClick();
                    break;
                case (char)Keys.D5:
                    fiveButton.PerformClick();
                    break;
                case (char)Keys.D6:
                    fiveButton.PerformClick();
                    break;
                case (char)Keys.D7:
                    fiveButton.PerformClick();
                    break;  
                case (char)Keys.D8:
                    fiveButton.PerformClick();
                    break;
                case (char)Keys.D9:
                    fiveButton.PerformClick();
                    break;
                case (char)Keys.Decimal:
                    decimalButton.PerformClick();
                    break;


            }
        }

        #region NumClicks
        private void zeroButton_Click(object sender, EventArgs e)
        {
            EnterNumber("0");
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            EnterNumber("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            EnterNumber("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            EnterNumber("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            EnterNumber("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            EnterNumber("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            EnterNumber("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            EnterNumber("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            EnterNumber("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            EnterNumber("9");
        }
        #endregion

        #region OtherClicks
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(num1 == String.Empty) //Checks if strings is empty
            {
                return;
            }
            else if (op == ' ') //Checks if which num we are on
            {
                num1 = num1.Remove(num1.Length-1);
            }
            else
            {
                num2 = num2.Remove(num2.Length-1);
            }
            UpdateText();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearCalc(); //Clear calculator
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Equal Pressed");
        }

        #endregion

        private void slashButton_Click(object sender, EventArgs e)
        {
            EnterOperation('/');
        }
    }
}
