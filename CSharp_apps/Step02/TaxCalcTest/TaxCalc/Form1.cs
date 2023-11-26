using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxCalc {
    public partial class Form1 : Form {
        public Form1( ) {
            InitializeComponent( );
        }

        /** 
         * This is another comment
         * It can span several lines
         * */

        // calculate and display tax and grandtotal based on subtotal
        private void calcBtn_Click( object sender, EventArgs e ) {
            double subtotal = 0.0;
            double tax = 0.0;
            double grandtotal = 0.0;            
            subtotal = 12.5;
            tax = 2.5;
            grandtotal = 15.0;
            subtotalTB.Text = subtotal.ToString();
            taxTB.Text = tax.ToString();
            grandTotalTB.Text = grandtotal.ToString();
        }
    }
}
