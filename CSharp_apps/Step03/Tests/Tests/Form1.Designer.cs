namespace Tests {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.output = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.userinput = new System.Windows.Forms.TextBox();
            this.moreTestsBtn = new System.Windows.Forms.Button();
            this.complexTestsBtn = new System.Windows.Forms.Button();
            this.nameinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericalTestsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 12);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(410, 110);
            this.output.TabIndex = 0;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(12, 137);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(103, 23);
            this.testBtn.TabIndex = 1;
            this.testBtn.Text = "Do Tests";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // userinput
            // 
            this.userinput.Location = new System.Drawing.Point(232, 134);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(190, 20);
            this.userinput.TabIndex = 2;
            // 
            // moreTestsBtn
            // 
            this.moreTestsBtn.Location = new System.Drawing.Point(12, 166);
            this.moreTestsBtn.Name = "moreTestsBtn";
            this.moreTestsBtn.Size = new System.Drawing.Size(103, 23);
            this.moreTestsBtn.TabIndex = 3;
            this.moreTestsBtn.Text = "Do More Tests";
            this.moreTestsBtn.UseVisualStyleBackColor = true;
            this.moreTestsBtn.Click += new System.EventHandler(this.moreTestsBtn_Click);
            // 
            // complexTestsBtn
            // 
            this.complexTestsBtn.Location = new System.Drawing.Point(12, 195);
            this.complexTestsBtn.Name = "complexTestsBtn";
            this.complexTestsBtn.Size = new System.Drawing.Size(103, 23);
            this.complexTestsBtn.TabIndex = 4;
            this.complexTestsBtn.Text = "Complex Tests";
            this.complexTestsBtn.UseVisualStyleBackColor = true;
            this.complexTestsBtn.Click += new System.EventHandler(this.complexTestsBtn_Click);
            // 
            // nameinput
            // 
            this.nameinput.Location = new System.Drawing.Point(232, 165);
            this.nameinput.Name = "nameinput";
            this.nameinput.Size = new System.Drawing.Size(190, 20);
            this.nameinput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter your name:";
            // 
            // numericalTestsBtn
            // 
            this.numericalTestsBtn.Location = new System.Drawing.Point(121, 195);
            this.numericalTestsBtn.Name = "numericalTestsBtn";
            this.numericalTestsBtn.Size = new System.Drawing.Size(103, 23);
            this.numericalTestsBtn.TabIndex = 8;
            this.numericalTestsBtn.Text = "Numerical Tests";
            this.numericalTestsBtn.UseVisualStyleBackColor = true;
            this.numericalTestsBtn.Click += new System.EventHandler(this.numericalTestsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 226);
            this.Controls.Add(this.numericalTestsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameinput);
            this.Controls.Add(this.complexTestsBtn);
            this.Controls.Add(this.moreTestsBtn);
            this.Controls.Add(this.userinput);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.output);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.TextBox userinput;
        private System.Windows.Forms.Button moreTestsBtn;
        private System.Windows.Forms.Button complexTestsBtn;
        private System.Windows.Forms.TextBox nameinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button numericalTestsBtn;
    }
}

