using System;
using System.Windows.Forms;

namespace TaxCalc {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        /** 
         * This is another comment
         * It can span several lines
         * */



        /*
                // This alternative version shows an example 
                // of initializing variables when they are declared
                // e.g. 
                // double subtotal = Double.Parse( subtotalTB.Text ); 
                // double tax = subtotal * TAXRATE;
                // double grandtotal = subtotal + tax;

                // calculate and display tax and grandtotal based on subtotal
                private void calcBtn_Click(object sender, EventArgs e) {
                    const double TAXRATE = 0.2;     // a single-line comment
                    double subtotal = Double.Parse(subtotalTB.Text);
                    double tax = subtotal * TAXRATE;
                    double grandtotal = subtotal + tax;
                    int roundedTotal;
                    subtotalTB.Text = subtotal.ToString();
                    taxTB.Text = tax.ToString();
                    grandTotalTB.Text = grandtotal.ToString();
                    roundedTotal = (int)grandtotal;
                    this.Text = roundedTotal.ToString();
                } 

        */


        // calculate and display tax and grandtotal based on subtotal
        private void calcBtn_Click(object sender, EventArgs e) {
            const double TAXRATE = 0.2;     // a single-line comment
            double subtotal = 0.0;
            double tax = 0.0;
            double grandtotal = 0.0;            
            int roundedTotal = 0;
            subtotal = Double.Parse(subtotalTB.Text);
            tax = subtotal * TAXRATE;
            grandtotal = subtotal + tax;
            taxTB.Text = tax.ToString();
            grandTotalTB.Text = grandtotal.ToString();
            // roundedTotal = (int)grandtotal;          // Here I could cast to int
            roundedTotal = Convert.ToInt32(grandtotal); // But I prefer to use the ToInt32 method
            this.Text = roundedTotal.ToString();
        }


    }
}
