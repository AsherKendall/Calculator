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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Delete key pressed");
            textBox.Text= "0";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Equal Pressed");
        }
        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
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

            }
        }

    }
}
