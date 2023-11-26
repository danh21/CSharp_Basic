using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.Text = "Display text";
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = "Hello world";
        }
    }
}
