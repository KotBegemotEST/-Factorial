using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factorial
{
    public partial class Form1 : Form
    {
        int userInput;
        string text;
        int result =1 ;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userInput = Int32.Parse(textBox1.Text);
            while (userInput >= 1) {
                result *= userInput;
                userInput -= 1;
            }

            label1.Text = "Result: " + result ;
        }
    }
}
