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

        private void deleteButton_Key(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Back:
                    deleteButton.PerformClick();
                    break;
            }
        }   
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Delete key pressed");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
