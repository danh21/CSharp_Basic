namespace Generics {
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
            this.listBtn = new System.Windows.Forms.Button();
            this.dictionaryBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 284);
            this.textBox1.TabIndex = 0;
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(23, 26);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(145, 23);
            this.listBtn.TabIndex = 1;
            this.listBtn.Text = "Create List";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // dictionaryBtn
            // 
            this.dictionaryBtn.Location = new System.Drawing.Point(23, 77);
            this.dictionaryBtn.Name = "dictionaryBtn";
            this.dictionaryBtn.Size = new System.Drawing.Size(145, 23);
            this.dictionaryBtn.TabIndex = 2;
            this.dictionaryBtn.Text = "Create Dictionary";
            this.dictionaryBtn.UseVisualStyleBackColor = true;
            this.dictionaryBtn.Click += new System.EventHandler(this.dictionaryBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(23, 128);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(145, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(23, 179);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(145, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(23, 230);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(145, 23);
            this.showBtn.TabIndex = 5;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(23, 290);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(145, 20);
            this.nameTB.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 454);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dictionaryBtn);
            this.Controls.Add(this.listBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button dictionaryBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.TextBox nameTB;
    }
}

