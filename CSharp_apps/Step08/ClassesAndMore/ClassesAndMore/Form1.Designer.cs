namespace ClassesAndMore {
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
            this.test1Btn = new System.Windows.Forms.Button();
            this.structTestBtn = new System.Windows.Forms.Button();
            this.suitsEnumTestBtn = new System.Windows.Forms.Button();
            this.suitsComboBox = new System.Windows.Forms.ComboBox();
            this.pictureCardsComboBox = new System.Windows.Forms.ComboBox();
            this.cardEnumTestBtn = new System.Windows.Forms.Button();
            this.dockTopBtn = new System.Windows.Forms.Button();
            this.docRightBtn = new System.Windows.Forms.Button();
            this.anchorTopRightBtn = new System.Windows.Forms.Button();
            this.anchorBottomLeftBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(698, 301);
            this.textBox1.TabIndex = 0;
            // 
            // test1Btn
            // 
            this.test1Btn.Location = new System.Drawing.Point(46, 18);
            this.test1Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1Btn.Name = "test1Btn";
            this.test1Btn.Size = new System.Drawing.Size(112, 35);
            this.test1Btn.TabIndex = 1;
            this.test1Btn.Text = "Test 1";
            this.test1Btn.UseVisualStyleBackColor = true;
            this.test1Btn.Click += new System.EventHandler(this.test1Btn_Click);
            // 
            // structTestBtn
            // 
            this.structTestBtn.Location = new System.Drawing.Point(46, 65);
            this.structTestBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.structTestBtn.Name = "structTestBtn";
            this.structTestBtn.Size = new System.Drawing.Size(112, 35);
            this.structTestBtn.TabIndex = 2;
            this.structTestBtn.Text = "Structs";
            this.structTestBtn.UseVisualStyleBackColor = true;
            this.structTestBtn.Click += new System.EventHandler(this.structTestBtn_Click);
            // 
            // suitsEnumTestBtn
            // 
            this.suitsEnumTestBtn.Location = new System.Drawing.Point(573, 374);
            this.suitsEnumTestBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.suitsEnumTestBtn.Name = "suitsEnumTestBtn";
            this.suitsEnumTestBtn.Size = new System.Drawing.Size(112, 35);
            this.suitsEnumTestBtn.TabIndex = 3;
            this.suitsEnumTestBtn.Text = "Pick a suit";
            this.suitsEnumTestBtn.UseVisualStyleBackColor = true;
            this.suitsEnumTestBtn.Click += new System.EventHandler(this.enumTestBtn_Click);
            // 
            // suitsComboBox
            // 
            this.suitsComboBox.FormattingEnabled = true;
            this.suitsComboBox.Items.AddRange(new object[] {
            "Clubs",
            "Spades",
            "Hearts",
            "Diamonds"});
            this.suitsComboBox.Location = new System.Drawing.Point(756, 377);
            this.suitsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.suitsComboBox.Name = "suitsComboBox";
            this.suitsComboBox.Size = new System.Drawing.Size(180, 28);
            this.suitsComboBox.TabIndex = 4;
            this.suitsComboBox.Text = "Spades";
            // 
            // pictureCardsComboBox
            // 
            this.pictureCardsComboBox.FormattingEnabled = true;
            this.pictureCardsComboBox.Items.AddRange(new object[] {
            "Jack",
            "Queen",
            "King"});
            this.pictureCardsComboBox.Location = new System.Drawing.Point(756, 437);
            this.pictureCardsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureCardsComboBox.Name = "pictureCardsComboBox";
            this.pictureCardsComboBox.Size = new System.Drawing.Size(180, 28);
            this.pictureCardsComboBox.TabIndex = 5;
            this.pictureCardsComboBox.Text = "Jack";
            // 
            // cardEnumTestBtn
            // 
            this.cardEnumTestBtn.Location = new System.Drawing.Point(573, 434);
            this.cardEnumTestBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardEnumTestBtn.Name = "cardEnumTestBtn";
            this.cardEnumTestBtn.Size = new System.Drawing.Size(112, 35);
            this.cardEnumTestBtn.TabIndex = 6;
            this.cardEnumTestBtn.Text = "Pick a card";
            this.cardEnumTestBtn.UseVisualStyleBackColor = true;
            this.cardEnumTestBtn.Click += new System.EventHandler(this.cardEnumTestBtn_Click);
            // 
            // dockTopBtn
            // 
            this.dockTopBtn.Location = new System.Drawing.Point(18, 317);
            this.dockTopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dockTopBtn.Name = "dockTopBtn";
            this.dockTopBtn.Size = new System.Drawing.Size(176, 35);
            this.dockTopBtn.TabIndex = 7;
            this.dockTopBtn.Text = "Dock Top";
            this.dockTopBtn.UseVisualStyleBackColor = true;
            this.dockTopBtn.Click += new System.EventHandler(this.dockTopBtn_Click);
            // 
            // docRightBtn
            // 
            this.docRightBtn.Location = new System.Drawing.Point(18, 377);
            this.docRightBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.docRightBtn.Name = "docRightBtn";
            this.docRightBtn.Size = new System.Drawing.Size(176, 35);
            this.docRightBtn.TabIndex = 8;
            this.docRightBtn.Text = "Dock Right";
            this.docRightBtn.UseVisualStyleBackColor = true;
            this.docRightBtn.Click += new System.EventHandler(this.dockRightBtn_Click);
            // 
            // anchorTopRightBtn
            // 
            this.anchorTopRightBtn.Location = new System.Drawing.Point(18, 437);
            this.anchorTopRightBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anchorTopRightBtn.Name = "anchorTopRightBtn";
            this.anchorTopRightBtn.Size = new System.Drawing.Size(176, 35);
            this.anchorTopRightBtn.TabIndex = 9;
            this.anchorTopRightBtn.Text = "Anchor Top Right";
            this.anchorTopRightBtn.UseVisualStyleBackColor = true;
            this.anchorTopRightBtn.Click += new System.EventHandler(this.anchorTopRightBtn_Click);
            // 
            // anchorBottomLeftBtn
            // 
            this.anchorBottomLeftBtn.Location = new System.Drawing.Point(18, 497);
            this.anchorBottomLeftBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anchorBottomLeftBtn.Name = "anchorBottomLeftBtn";
            this.anchorBottomLeftBtn.Size = new System.Drawing.Size(176, 35);
            this.anchorBottomLeftBtn.TabIndex = 10;
            this.anchorBottomLeftBtn.Text = "Anchor Bottom Left";
            this.anchorBottomLeftBtn.UseVisualStyleBackColor = true;
            this.anchorBottomLeftBtn.Click += new System.EventHandler(this.anchorBottomLeftBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 575);
            this.Controls.Add(this.anchorBottomLeftBtn);
            this.Controls.Add(this.anchorTopRightBtn);
            this.Controls.Add(this.docRightBtn);
            this.Controls.Add(this.dockTopBtn);
            this.Controls.Add(this.cardEnumTestBtn);
            this.Controls.Add(this.pictureCardsComboBox);
            this.Controls.Add(this.suitsComboBox);
            this.Controls.Add(this.suitsEnumTestBtn);
            this.Controls.Add(this.structTestBtn);
            this.Controls.Add(this.test1Btn);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button test1Btn;
        private System.Windows.Forms.Button structTestBtn;
        private System.Windows.Forms.Button suitsEnumTestBtn;
        private System.Windows.Forms.ComboBox suitsComboBox;
        private System.Windows.Forms.ComboBox pictureCardsComboBox;
        private System.Windows.Forms.Button cardEnumTestBtn;
        private System.Windows.Forms.Button dockTopBtn;
        private System.Windows.Forms.Button docRightBtn;
        private System.Windows.Forms.Button anchorTopRightBtn;
        private System.Windows.Forms.Button anchorBottomLeftBtn;
    }
}

