using System;
using System.Windows.Forms;

namespace DataTypes {
    public partial class Form1 : Form {
        public Form1( ) {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e ) {
            // These are constant value that can't be changed
            const string WARNING_MSG = "Warning! Do not change! ";
            const double TAXRATE = 0.2;

            // These are variables - they can be changed
            string mystring = "Hello world";
            char mychar = '!';
            int myint = 100;
            int someotherint;
            double mydouble = 100.75 * TAXRATE;
            string msg = "Goodbye";
            msg = WARNING_MSG + mystring + mychar + "\r\n";
            myint = 200;
            someotherint = myint * 2;
            textBox1.Text = msg;
            textBox1.AppendText("You owe: " + mydouble + " groats!");
        }
    }
}
