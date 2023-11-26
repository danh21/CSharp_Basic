using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticOps {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {            
            textBox1.AppendText("100+7=" + (100 + 7) + "\r\n");
            textBox1.AppendText("100-7=" + (100 - 7) + "\r\n");
            textBox1.AppendText("100*7=" + (100 * 7) + "\r\n");
            textBox1.AppendText("100/7=" + (100 / 7) + "\r\n");
            textBox1.AppendText("100%7=" + (100 % 7) + "\r\n");
           // textBox1.AppendText("Result =" + 100);
            textBox1.AppendText("155+3=" + 155 + 3 + "\r\n");
            textBox1.AppendText("155+3=" + (155 + 3) + "\r\n");
        }
        
    }
}
