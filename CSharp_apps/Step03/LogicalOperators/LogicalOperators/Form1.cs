using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicalOperators {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int age;
            int number_of_children;
            double salary;
            double bonus;

            age = 25;
            number_of_children = 1;
            salary = 20000.00;
            bonus = 500.00;

            if ((age <= 30) && (salary >= 30000.00)) {
                textBox1.AppendText("You are a rich young person\r\n");
            } else { 
                textBox1.AppendText("You are not a rich young person\r\n");
            }

            // Negate this test with a !
            if (!((age <= 30) && (salary >= 30000.00))) {
                textBox1.AppendText("You are a rich young person\r\n");
            } else {
                textBox1.AppendText("You are not a rich young person\r\n");
            }

            if ((age <= 30) || (salary >= 30000.00)) {
                textBox1.AppendText("You are either rich or young or both\r\n");
            } else {
                textBox1.AppendText("You are not neither rich nor young\r\n");
            }           

            if ((age <= 30) && (salary >= 30000.00) && (number_of_children != 0)) {
                textBox1.AppendText("You are a rich young parent\r\n");
            } else {
                textBox1.AppendText("You are not a rich young parent\r\n");
            }

            // This test is too complicated!!!
            if (age > 20 && salary > 10000.00 || number_of_children == 1 && bonus > 800.00 ) {
                textBox1.AppendText("You've won the star prize!\r\n");
            } else {
                textBox1.AppendText("Sorry, you are not a winner\r\n");
            }
        }
    }
}
