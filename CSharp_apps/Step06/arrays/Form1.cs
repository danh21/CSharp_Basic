using System;
using System.Windows.Forms;

namespace arrays
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private TextBox textBox0;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run Test";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(297, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(29, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(297, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(29, 15);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(297, 22);
            this.textBox0.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(358, 323);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        public class MyClass
        {
            private string _name;

            public MyClass(string aName)
            {
                _name = aName;
            }

            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string[] myArray = new string[] { "one", "two", "three" };
            string[] myArray2;
            myArray2 = new string[3] { "four", "five", "six" };
            string[] myArray3 = { "seven", "eight", "nine" };
            MyClass[] myObjectArray = new MyClass[3];
            // loop 0
            for (int i = 0; i <= 2; i++)
            {
                textBox0.Text += myArray[i] + ". ";
            }
            // loop 1
            for (int i = 0; i <= 2; i++)
            {
                myObjectArray[i] = new MyClass("Object #" + i + ". ");
            }
            // loop 2
            for (int i = 0; i <= myArray.Length - 1; i++)
            {
                textBox1.Text += myArray[i] + ". ";
            }
            // alternative version
            //for( int i = 0; i < myArray.Length; i++ ) {
            //    textBox1.Text = textBox1.Text + myArray[i] + ". ";
            //}
            // loop 3
            for (int i = myArray2.GetLowerBound(0); i <= myArray2.GetUpperBound(0); i++)
            {
                textBox2.Text += myArray2[i] + ". ";
            }
            // loop 4
            for (int i = 0; i <= myObjectArray.GetUpperBound(0); i++)
            {
                textBox3.Text += myObjectArray[i].Name;
            }
            // loop 5
            foreach (MyClass myob in myObjectArray)
            {
                textBox4.Text += myob.Name;
            }


        }
    }
}
