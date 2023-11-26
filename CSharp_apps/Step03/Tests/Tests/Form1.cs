using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tests {
    public partial class Form1 : Form {
        public Form1( ) {
            InitializeComponent( );
        }

        private void testBtn_Click( object sender, EventArgs e ) {
            if( userinput.Text == "" ) {
                output.Text = "You didn't enter anything";
            } else if( (userinput.Text == "hello" ) || ( userinput.Text == "hi" ) ) {
                output.Text = "Hello to you too!";
            } else {
                output.Text = "I don't understand that!";
            }
        }

        private void moreTestsBtn_Click( object sender, EventArgs e ) {
            switch( userinput.Text ) {
                case "":
                    output.Text = "You didn't enter anything";
                    break;
                case "hello":
                case "hi":
                    output.Text = userinput.Text+ " to you too!";
                    break;
                default:
                    output.Text = "I don't understand that!";
                    break;
            }
        }

        private void complexTestsBtn_Click( object sender, EventArgs e ) {
            string msg;
            string name;
            int msglen;
            int namelen;
            msg = userinput.Text;
            name = nameinput.Text;
            msglen = userinput.TextLength;
            namelen = nameinput.TextLength;
            if( ( msglen == 0 ) && ( namelen == 0 ) ) {
                output.Text = "You haven't entered anything!";
            } else if( ( msglen == 0 ) || ( namelen == 0 ) ) {
                output.Text = "You must enter something into both text boxes";
            } else if( ( msg != "hi" ) && ( msg != "hello" ) ) {
                output.Text = "Please enter a friendly greeting ('hi' or 'hello' would be nice)";
            } else {
                output.Text = "Well, " + msg + " to you too, " + name;
            }
        }

        private void numericalTestsBtn_Click( object sender, EventArgs e ) {
            /*
             * Try different tests such as:
             * i == i
             * i < j
             * i <= j
             * i > j
             * i >= j
             * i != j
             * i != i
             * */
            int i = 100;
            int j = 200;
            if( i != j ) {
                output.Text = "Test is true";
            } else {
                output.Text = "Test is false";
            }

        }
    }
}
