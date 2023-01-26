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
        string input;
        string num1;
        string num2;
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
                textBox.Text = num1.ToString() + ' ' + op + ' ' + '0';
            }
            else
            {
                textBox.Text = num1.ToString() + ' ' + op + ' ' + num2.ToString();
            }
            
            return;
        }

        public void EnterNumber(string input)
        {
            if(op == ' ')
            {
                num1 = num1 + input;
                return;
            }
            else
            {
                num2 = num2 + input;
                return;
            }
        }

        private void PerformOperation(double num1,double num2,char op)
        {
            switch (op)
            {
                case 'x':
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
            return;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Delete key pressed");
            textBox.Text= "0";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearCalc();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Equal Pressed");
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

    }
}
