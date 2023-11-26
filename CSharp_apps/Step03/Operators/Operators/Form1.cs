using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Operators {
    public partial class Form1 : Form {
        public Form1( ) {
            InitializeComponent( );
        }

        private void addToTextBox( string s ) {
            // write line to text box
            tb.AppendText( s + "\r\n");
        }

        private void testOpsBtn_Click( object sender, EventArgs e ) {
            // declare and init variables to default values
            int a = 10;
            int b = 2;
            tb.Clear( );
            addToTextBox( "a+b  : " + ( a + b ) );
            addToTextBox( "a += b  : " + ( a += b ) );
            addToTextBox( "a-b  : " + ( a - b ) );
            addToTextBox( "a -= b  : " + ( a -= b ) );
            addToTextBox( "a*b  : " + ( a * b ) );
            addToTextBox( "a *= b  : " + ( a *= b ) );
            addToTextBox( "a/b  : " + ( a / b ) );
            addToTextBox( "a /= b  : " + ( a /= b ) );
            a = 10;
            b = ++a;
            addToTextBox("[b = ++a] ... a=" + a + " b=" + b);
            a = 10;
            b = a++;
            addToTextBox("[b = a++] ... a=" + a + " b=" + b);

        }
    }
}
