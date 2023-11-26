namespace Operators {
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
            this.tb = new System.Windows.Forms.TextBox();
            this.testOpsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(13, 13);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(635, 269);
            this.tb.TabIndex = 0;
            // 
            // testOpsBtn
            // 
            this.testOpsBtn.Location = new System.Drawing.Point(12, 302);
            this.testOpsBtn.Name = "testOpsBtn";
            this.testOpsBtn.Size = new System.Drawing.Size(160, 23);
            this.testOpsBtn.TabIndex = 1;
            this.testOpsBtn.Text = "Test Operators";
            this.testOpsBtn.UseVisualStyleBackColor = true;
            this.testOpsBtn.Click += new System.EventHandler(this.testOpsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 337);
            this.Controls.Add(this.testOpsBtn);
            this.Controls.Add(this.tb);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button testOpsBtn;
    }
}

