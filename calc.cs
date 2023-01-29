using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calc : Form
    {
        string num1 = string.Empty;
        string num2 = string.Empty ;
        char op = ' ';
        double answer = 0;
        List<string> history = new List<string>();
        List<double> totals = new List<double>();

        #region functions
        public calc()
        {
            InitializeComponent();
        }

        private void UpdateText() //Check if we need to update textbox
        {
            if(String.IsNullOrEmpty(num1))
            {
                textBox.Text = answer.ToString();
            }
            else if(op == ' ')
            {
                textBox.Text = num1.ToString();
            }else if (String.IsNullOrEmpty(num2))
            {
                textBox.Text = num1 + " " + op.ToString() + " ";
            }
            else
            {
                textBox.Text = num1 + " " + op + " " + num2;
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
                PerformOperation();
            }
            UpdateText();
        }

        public void PerformOperation()
        {

            if (num1.All(char.IsDigit) && num2.All(char.IsDigit)) //If normal operation
            {
                double num3 = Convert.ToDouble(num1);
                double num4 = Convert.ToDouble(num2);
                switch (op)
                {
                    case '*':
                        answer = num3 * num4; break;
                    case '+':
                        answer = num3 + num4; break;
                    case '-':
                        answer = num3 - num4; break;
                    case '/':
                        answer = num3 / num4; break;
                    case '^':
                        answer = Math.Pow(num3, num4); break;
                }
            }
            
            history.Add(textBox.Text);
            totals.Add(answer);
            HistoryBox.Items.Add(history.Last() + " = " + totals.Last());
            op = ' ';
            num1 = Convert.ToString(answer);
            num2 = string.Empty;
            answer = 0;
            UpdateText();
        }

        public void ClearCalc()
        {
            num1 = string.Empty;
            num2 = string.Empty;
            op = ' ';
            answer = 0;
            textBox.Text = "0";
            history.Clear(); //Clears History
            totals.Clear(); //Clears totals
            HistoryBox.Items.Clear(); //Clears history text
            UpdateText();
        }

        #endregion

        #region keypresses
        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
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
                case '/':
                    slashButton.PerformClick();
                    break;
                case '+':
                    addButton.PerformClick();
                    break;
                case '*':
                    multiButton.PerformClick();
                    break;
                case '-':
                    minusButton.PerformClick();
                    break;
                case '.':
                    decimalButton.PerformClick();
                    break;


            }
        }
        #endregion

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
        private void decimalButton_Click(object sender, EventArgs e)
        {
            EnterNumber(".");
        }

        private void symbChangeButton_Click(object sender, EventArgs e)
        {
            if (num2 != string.Empty && num2 != "0")
            {
                if (num2.Substring(0, 1) == "-")
                {
                    num2.Remove(0, 1);
                }
                else
                {
                    num2 = '-' + num2;
                }
            }
            else if (op != ' ') //Check if we are trying to negate operator
            {
                return;
            }
            else if (num1 != string.Empty)
            {
                if (num1.Substring(0, 1) == "-" && num1 != "0") //Checks if already negative
                {
                    num1.Remove(0, 1);
                }
                else
                {
                    num1 = "-"+ num1;
                }
            }

            UpdateText();
        }

        #endregion

        #region OtherClicks
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(num1 == String.Empty) //Checks if strings is empty
            {
                UpdateText();
                return;
            }
            else if (num2 != String.Empty) //Checks if num2 was started
            {
                num2 = num2.Remove(num2.Length - 1);
            }
            else if (op == ' ') //Checks which num we are on
            {
                num1 = num1.Remove(num1.Length-1);
            }
            else //Delete Operator
            {
                op = ' ';
            }
            UpdateText();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearCalc(); //Clear calculator
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            if (num1 == String.Empty) //Checks if strings is empty
            {
                return;
            }
            else if (num2 != String.Empty) //Checks if num2 was started
            {
                num2 = string.Empty;
            }
            else if (op == ' ') //Checks which num we are on
            {
                num1 = string.Empty;
            }
            else //Delete Operator
            {
                op = ' ';
            }
            UpdateText();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if(op != ' ' && String.IsNullOrEmpty(num2) == false)
            {
                PerformOperation();
            }
        }

        private void slashButton_Click(object sender, EventArgs e)
        {
            EnterOperation('/');
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EnterOperation('+');
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            EnterOperation('-');
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            EnterOperation('*');
        }

        private void sqrtButton_Click(object sender, EventArgs e) //Done in function so we don't have to mess with strings
        {
            if(op == ' ')
            {
                answer = Math.Sqrt(Convert.ToDouble(num1));
                history.Add("Sqrt(" + answer +")");
                totals.Add(answer);
                num1 = Convert.ToString(answer);
            }else if(String.IsNullOrEmpty(num2))
            {

            }
            else
            {

            }

            HistoryBox.Items.Add(history.Last() + " = " + totals.Last());
            op = ' ';
            num1 = Convert.ToString(answer);
            num2 = string.Empty;
            answer = 0;
            UpdateText();
        }

        #endregion


    }
}
