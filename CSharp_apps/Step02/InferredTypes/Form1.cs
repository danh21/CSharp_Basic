using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InferredTypes {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) {
            var num = 100;
            var num2 = 200.5;
            var str = "Hello world";
            object[] somethings = { str, num, num2 };
            // str = 2; // Not allowed!

            textBox1.Text = str + " is a: " + str.GetType() + "\r\n";
            textBox1.AppendText(num + " is a: " + num.GetType() + "\r\n");
            textBox1.AppendText(num2 + " is a: " + num2.GetType() + "\r\n");
            textBox1.AppendText("--- Let's see what is in the somethings array ----\r\n");

            foreach (var thing in somethings) {
                textBox1.AppendText(thing + " is a: " + thing.GetType() + "\r\n");
            }
        }
    }
}
