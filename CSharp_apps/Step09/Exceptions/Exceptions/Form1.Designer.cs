namespace Exceptions {
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
            this.calc3Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calc2Btn = new System.Windows.Forms.Button();
            this.calcBtn = new System.Windows.Forms.Button();
            this.grandTotBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.subTotBox = new System.Windows.Forms.TextBox();
            this.calc4Btn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.calc5Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calc3Btn
            // 
            this.calc3Btn.Location = new System.Drawing.Point(268, 104);
            this.calc3Btn.Name = "calc3Btn";
            this.calc3Btn.Size = new System.Drawing.Size(75, 23);
            this.calc3Btn.TabIndex = 17;
            this.calc3Btn.Text = "Calc&3";
            this.calc3Btn.Click += new System.EventHandler(this.calc3Btn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "grand total:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "tax:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "subtotal:";
            // 
            // calc2Btn
            // 
            this.calc2Btn.Location = new System.Drawing.Point(268, 75);
            this.calc2Btn.Name = "calc2Btn";
            this.calc2Btn.Size = new System.Drawing.Size(75, 23);
            this.calc2Btn.TabIndex = 13;
            this.calc2Btn.Text = "Calc&2";
            this.calc2Btn.Click += new System.EventHandler(this.calc2Btn_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(268, 48);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 12;
            this.calcBtn.Text = "&Calc";
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // grandTotBox
            // 
            this.grandTotBox.Location = new System.Drawing.Point(132, 112);
            this.grandTotBox.Name = "grandTotBox";
            this.grandTotBox.Size = new System.Drawing.Size(100, 20);
            this.grandTotBox.TabIndex = 11;
            // 
            // taxBox
            // 
            this.taxBox.Location = new System.Drawing.Point(132, 80);
            this.taxBox.Name = "taxBox";
            this.taxBox.Size = new System.Drawing.Size(100, 20);
            this.taxBox.TabIndex = 10;
            // 
            // subTotBox
            // 
            this.subTotBox.Location = new System.Drawing.Point(132, 48);
            this.subTotBox.Name = "subTotBox";
            this.subTotBox.Size = new System.Drawing.Size(100, 20);
            this.subTotBox.TabIndex = 9;
            // 
            // calc4Btn
            // 
            this.calc4Btn.Location = new System.Drawing.Point(268, 133);
            this.calc4Btn.Name = "calc4Btn";
            this.calc4Btn.Size = new System.Drawing.Size(75, 23);
            this.calc4Btn.TabIndex = 19;
            this.calc4Btn.Text = "Calc&4";
            this.calc4Btn.UseVisualStyleBackColor = true;
            this.calc4Btn.Click += new System.EventHandler(this.calc4Btn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(263, 13);
            this.statusLabel.TabIndex = 20;
            this.statusLabel.Text = "Welcome to our tax Calculator. Please enter a subtotal";
            // 
            // calc5Btn
            // 
            this.calc5Btn.Location = new System.Drawing.Point(268, 163);
            this.calc5Btn.Name = "calc5Btn";
            this.calc5Btn.Size = new System.Drawing.Size(75, 23);
            this.calc5Btn.TabIndex = 21;
            this.calc5Btn.Text = "Calc&5";
            this.calc5Btn.UseVisualStyleBackColor = true;
            this.calc5Btn.Click += new System.EventHandler(this.calc5Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 222);
            this.Controls.Add(this.calc5Btn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.calc4Btn);
            this.Controls.Add(this.calc3Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calc2Btn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.grandTotBox);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.subTotBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calc3Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calc2Btn;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.TextBox grandTotBox;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.TextBox subTotBox;
        private System.Windows.Forms.Button calc4Btn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button calc5Btn;
    }
}

