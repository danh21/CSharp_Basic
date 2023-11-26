namespace TaxCalc {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subtotalTB = new System.Windows.Forms.TextBox();
            this.taxTB = new System.Windows.Forms.TextBox();
            this.grandTotalTB = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grand Total:";
            // 
            // subtotalTB
            // 
            this.subtotalTB.Location = new System.Drawing.Point(174, 37);
            this.subtotalTB.Name = "subtotalTB";
            this.subtotalTB.Size = new System.Drawing.Size(100, 20);
            this.subtotalTB.TabIndex = 3;
            // 
            // taxTB
            // 
            this.taxTB.Enabled = false;
            this.taxTB.Location = new System.Drawing.Point(174, 69);
            this.taxTB.Name = "taxTB";
            this.taxTB.Size = new System.Drawing.Size(100, 20);
            this.taxTB.TabIndex = 4;
            // 
            // grandTotalTB
            // 
            this.grandTotalTB.Enabled = false;
            this.grandTotalTB.Location = new System.Drawing.Point(174, 103);
            this.grandTotalTB.Name = "grandTotalTB";
            this.grandTotalTB.Size = new System.Drawing.Size(100, 20);
            this.grandTotalTB.TabIndex = 5;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(174, 146);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(100, 23);
            this.calcBtn.TabIndex = 6;
            this.calcBtn.Text = "Calc Tax";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 209);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.grandTotalTB);
            this.Controls.Add(this.taxTB);
            this.Controls.Add(this.subtotalTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subtotalTB;
        private System.Windows.Forms.TextBox taxTB;
        private System.Windows.Forms.TextBox grandTotalTB;
        private System.Windows.Forms.Button calcBtn;
    }
}

