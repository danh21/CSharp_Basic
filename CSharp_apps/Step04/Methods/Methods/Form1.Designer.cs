namespace Methods {
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.paramTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(569, 168);
            this.textBox1.TabIndex = 0;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(36, 210);
            this.testBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(221, 28);
            this.testBtn.TabIndex = 1;
            this.testBtn.Text = "Run Method Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // paramTestBtn
            // 
            this.paramTestBtn.Location = new System.Drawing.Point(385, 210);
            this.paramTestBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paramTestBtn.Name = "paramTestBtn";
            this.paramTestBtn.Size = new System.Drawing.Size(221, 28);
            this.paramTestBtn.TabIndex = 2;
            this.paramTestBtn.Text = "Value, Ref and Out Parameters";
            this.paramTestBtn.UseVisualStyleBackColor = true;
            this.paramTestBtn.Click += new System.EventHandler(this.paramTestBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 267);
            this.Controls.Add(this.paramTestBtn);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button paramTestBtn;
    }
}

