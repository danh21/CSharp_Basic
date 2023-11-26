namespace ifelse {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ifBtn = new System.Windows.Forms.Button();
            this.ifelseBtn = new System.Windows.Forms.Button();
            this.if1Btn = new System.Windows.Forms.Button();
            this.if2Btn = new System.Windows.Forms.Button();
            this.if3Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "How much money have you got?";
            // 
            // ifBtn
            // 
            this.ifBtn.Location = new System.Drawing.Point(54, 76);
            this.ifBtn.Name = "ifBtn";
            this.ifBtn.Size = new System.Drawing.Size(75, 23);
            this.ifBtn.TabIndex = 2;
            this.ifBtn.Text = "if test";
            this.ifBtn.UseVisualStyleBackColor = true;
            this.ifBtn.Click += new System.EventHandler(this.ifBtn_Click);
            // 
            // ifelseBtn
            // 
            this.ifelseBtn.Location = new System.Drawing.Point(54, 105);
            this.ifelseBtn.Name = "ifelseBtn";
            this.ifelseBtn.Size = new System.Drawing.Size(75, 23);
            this.ifelseBtn.TabIndex = 3;
            this.ifelseBtn.Text = "if..else test";
            this.ifelseBtn.UseVisualStyleBackColor = true;
            this.ifelseBtn.Click += new System.EventHandler(this.ifelseBtn_Click);
            // 
            // if1Btn
            // 
            this.if1Btn.Location = new System.Drawing.Point(54, 171);
            this.if1Btn.Name = "if1Btn";
            this.if1Btn.Size = new System.Drawing.Size(75, 23);
            this.if1Btn.TabIndex = 4;
            this.if1Btn.Text = "if #1";
            this.if1Btn.UseVisualStyleBackColor = true;
            this.if1Btn.Click += new System.EventHandler(this.if1Btn_Click);
            // 
            // if2Btn
            // 
            this.if2Btn.Location = new System.Drawing.Point(54, 200);
            this.if2Btn.Name = "if2Btn";
            this.if2Btn.Size = new System.Drawing.Size(75, 23);
            this.if2Btn.TabIndex = 5;
            this.if2Btn.Text = "if #2";
            this.if2Btn.UseVisualStyleBackColor = true;
            this.if2Btn.Click += new System.EventHandler(this.if2Btn_Click);
            // 
            // if3Btn
            // 
            this.if3Btn.Location = new System.Drawing.Point(54, 227);
            this.if3Btn.Name = "if3Btn";
            this.if3Btn.Size = new System.Drawing.Size(75, 23);
            this.if3Btn.TabIndex = 6;
            this.if3Btn.Text = "if #3";
            this.if3Btn.UseVisualStyleBackColor = true;
            this.if3Btn.Click += new System.EventHandler(this.if3Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.if3Btn);
            this.Controls.Add(this.if2Btn);
            this.Controls.Add(this.if1Btn);
            this.Controls.Add(this.ifelseBtn);
            this.Controls.Add(this.ifBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ifBtn;
        private System.Windows.Forms.Button ifelseBtn;
        private System.Windows.Forms.Button if1Btn;
        private System.Windows.Forms.Button if2Btn;
        private System.Windows.Forms.Button if3Btn;
    }
}

