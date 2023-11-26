using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyOb {
    public partial class Form1 : Form {

        MyClass ob;

        public Form1( ) {
            InitializeComponent( );
        }

        private void createObBtn_Click( object sender, EventArgs e ) {
            ob = new MyClass( );
        }

        private void setStrBtn_Click( object sender, EventArgs e ) {
            // test if the ob has been created (it's not null) before trying to 
            // call one of its methods
            if( ob != null ) {
                ob.SetS( "A new string" );
            }
        }

        private void getStrBtn_Click( object sender, EventArgs e ) {
            if( ob != null ) {
                textBox1.Text = ob.GetS( );
            }
        }
    }

    class MyClass {
        private string _s;

        public MyClass( ) {
            _s = "Hello world";
        }

        public string GetS( ) {
            return _s;
        }

        public void SetS( string aString ) {
            _s = aString;
        }
    }
}
