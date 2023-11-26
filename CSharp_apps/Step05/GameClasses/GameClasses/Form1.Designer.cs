namespace GameClasses {
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
            this.creatObjectsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(567, 232);
            this.textBox1.TabIndex = 0;
            // 
            // creatObjectsBtn
            // 
            this.creatObjectsBtn.Location = new System.Drawing.Point(30, 267);
            this.creatObjectsBtn.Name = "creatObjectsBtn";
            this.creatObjectsBtn.Size = new System.Drawing.Size(161, 23);
            this.creatObjectsBtn.TabIndex = 1;
            this.creatObjectsBtn.Text = "Create Objects";
            this.creatObjectsBtn.UseVisualStyleBackColor = true;
            this.creatObjectsBtn.Click += new System.EventHandler(this.creatObjectsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 301);
            this.Controls.Add(this.creatObjectsBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button creatObjectsBtn;
    }
}

