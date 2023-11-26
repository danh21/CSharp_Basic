using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelse {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void ifBtn_Click(object sender, EventArgs e) {
            double someMoney;
            someMoney = Double.Parse(textBox1.Text);
            if (someMoney > 100.00) {
                MessageBox.Show("You have lots of money!");
            }
        }

        private void ifelseBtn_Click(object sender, EventArgs e) {
            double someMoney;
            someMoney = Double.Parse(textBox1.Text);
            if (someMoney > 100.00) {
                MessageBox.Show("You have lots of money!");
            } else {
                MessageBox.Show("You need more money...");
            }
        }

        /* What's the difference between these 2 functions?
         * 
         * They are supposed to pay out $100 only if x is greater than 10
         * If x is 10 or less, they should not pay out. But only one
         * function works correctly
         * 
         * */
        private void if1Btn_Click(object sender, EventArgs e) {
            int x;
            x = Int16.Parse(textBox1.Text);
            if (x > 10) 
                MessageBox.Show("Great news!");
                x = 100;
                MessageBox.Show("You've won $" + x);                     
        }

        private void if2Btn_Click(object sender, EventArgs e) {
            int x;
            x = Int16.Parse(textBox1.Text);
            if (x > 10) {
                MessageBox.Show("Great news!");
                x = 100;
                MessageBox.Show("You've won $" + x);
            }
        }
        
        // This is the most civilised function. It uses curly brackets to 
        // enclose all the statments that execute when the test is true
        // and an 'else' part shows a message when the test is false
        private void if3Btn_Click(object sender, EventArgs e) {
            int x;
            x = Int16.Parse(textBox1.Text);
            if (x > 10) {
                MessageBox.Show("Great news!");
                x = 100;
                MessageBox.Show("You've won $" + x);
            } else {
                x = 0;
                MessageBox.Show("Bad luck. Your payout is $" + x);
            }
        }
    }
}
