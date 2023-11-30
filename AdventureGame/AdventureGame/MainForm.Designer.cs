using System;
using System.Collections.Generic;
using System.Text;

namespace game {
    partial class MainForm {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox displayTB;
        private System.Windows.Forms.Button lookBtn;
        private System.Windows.Forms.Button northBtn;
        private System.Windows.Forms.Button westBtn;
        private System.Windows.Forms.Button southBtn;
        private System.Windows.Forms.Button eastBtn;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem LoadmenuItem;
        private System.Windows.Forms.MenuItem SavemenuItem;
        private System.Windows.Forms.MenuItem ExitmenuItem;
        private System.Windows.Forms.MenuItem RestartmenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dropBtn;
        private System.Windows.Forms.Button takeBtn;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Button invBtn;
        private System.Windows.Forms.Button lookAtBtn;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing ) {
            if( disposing ) {
                if( components != null ) {
                    components.Dispose( );
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.components = new System.ComponentModel.Container();
            this.displayTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.invBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lookAtBtn = new System.Windows.Forms.Button();
            this.dropBtn = new System.Windows.Forms.Button();
            this.takeBtn = new System.Windows.Forms.Button();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.southBtn = new System.Windows.Forms.Button();
            this.eastBtn = new System.Windows.Forms.Button();
            this.westBtn = new System.Windows.Forms.Button();
            this.northBtn = new System.Windows.Forms.Button();
            this.lookBtn = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.LoadmenuItem = new System.Windows.Forms.MenuItem();
            this.SavemenuItem = new System.Windows.Forms.MenuItem();
            this.RestartmenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.ExitmenuItem = new System.Windows.Forms.MenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayTB
            // 
            this.displayTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTB.Location = new System.Drawing.Point(0, 0);
            this.displayTB.Multiline = true;
            this.displayTB.Name = "displayTB";
            this.displayTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTB.Size = new System.Drawing.Size(555, 317);
            this.displayTB.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.invBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.testBtn);
            this.panel1.Controls.Add(this.southBtn);
            this.panel1.Controls.Add(this.eastBtn);
            this.panel1.Controls.Add(this.westBtn);
            this.panel1.Controls.Add(this.northBtn);
            this.panel1.Controls.Add(this.lookBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 190);
            this.panel1.TabIndex = 1;
            // 
            // invBtn
            // 
            this.invBtn.Location = new System.Drawing.Point(278, 148);
            this.invBtn.Name = "invBtn";
            this.invBtn.Size = new System.Drawing.Size(90, 26);
            this.invBtn.TabIndex = 11;
            this.invBtn.Text = "Inventory";
            this.invBtn.Click += new System.EventHandler(this.InvBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lookAtBtn);
            this.groupBox1.Controls.Add(this.dropBtn);
            this.groupBox1.Controls.Add(this.takeBtn);
            this.groupBox1.Controls.Add(this.inputTB);
            this.groupBox1.Location = new System.Drawing.Point(10, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 157);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Do to Object...";
            // 
            // lookAtBtn
            // 
            this.lookAtBtn.Location = new System.Drawing.Point(10, 111);
            this.lookAtBtn.Name = "lookAtBtn";
            this.lookAtBtn.Size = new System.Drawing.Size(90, 26);
            this.lookAtBtn.TabIndex = 6;
            this.lookAtBtn.Text = "Look At";
            this.lookAtBtn.Click += new System.EventHandler(this.LookAtBtn_Click);
            // 
            // dropBtn
            // 
            this.dropBtn.Location = new System.Drawing.Point(130, 63);
            this.dropBtn.Name = "dropBtn";
            this.dropBtn.Size = new System.Drawing.Size(90, 27);
            this.dropBtn.TabIndex = 5;
            this.dropBtn.Text = "Drop";
            this.dropBtn.Click += new System.EventHandler(this.DropBtn_Click);
            // 
            // takeBtn
            // 
            this.takeBtn.Location = new System.Drawing.Point(10, 63);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(90, 27);
            this.takeBtn.TabIndex = 4;
            this.takeBtn.Text = "Take";
            this.takeBtn.Click += new System.EventHandler(this.TakeBtn_Click);
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(14, 27);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(212, 22);
            this.inputTB.TabIndex = 3;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(278, 55);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(90, 27);
            this.testBtn.TabIndex = 8;
            this.testBtn.Text = "Test";
            this.testBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // southBtn
            // 
            this.southBtn.Location = new System.Drawing.Point(432, 92);
            this.southBtn.Name = "southBtn";
            this.southBtn.Size = new System.Drawing.Size(58, 28);
            this.southBtn.TabIndex = 7;
            this.southBtn.Text = "S";
            this.southBtn.Click += new System.EventHandler(this.SouthBtn_Click);
            // 
            // eastBtn
            // 
            this.eastBtn.Location = new System.Drawing.Point(470, 55);
            this.eastBtn.Name = "eastBtn";
            this.eastBtn.Size = new System.Drawing.Size(58, 28);
            this.eastBtn.TabIndex = 6;
            this.eastBtn.Text = "E";
            this.eastBtn.Click += new System.EventHandler(this.EastBtn_Click);
            // 
            // westBtn
            // 
            this.westBtn.Location = new System.Drawing.Point(394, 55);
            this.westBtn.Name = "westBtn";
            this.westBtn.Size = new System.Drawing.Size(58, 28);
            this.westBtn.TabIndex = 5;
            this.westBtn.Text = "W";
            this.westBtn.Click += new System.EventHandler(this.WestBtn_Click);
            // 
            // northBtn
            // 
            this.northBtn.Location = new System.Drawing.Point(432, 18);
            this.northBtn.Name = "northBtn";
            this.northBtn.Size = new System.Drawing.Size(58, 28);
            this.northBtn.TabIndex = 4;
            this.northBtn.Text = "N";
            this.northBtn.Click += new System.EventHandler(this.NorthBtn_Click);
            // 
            // lookBtn
            // 
            this.lookBtn.Location = new System.Drawing.Point(278, 102);
            this.lookBtn.Name = "lookBtn";
            this.lookBtn.Size = new System.Drawing.Size(90, 26);
            this.lookBtn.TabIndex = 3;
            this.lookBtn.Text = "Look";
            this.lookBtn.Click += new System.EventHandler(this.LookBtn_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.LoadmenuItem,
            this.SavemenuItem,
            this.RestartmenuItem,
            this.menuItem4,
            this.ExitmenuItem});
            this.menuItem1.Text = "&File";
            // 
            // LoadmenuItem
            // 
            this.LoadmenuItem.Index = 0;
            this.LoadmenuItem.Text = "&Load";
            this.LoadmenuItem.Click += new System.EventHandler(this.LoadmenuItem_Click);
            // 
            // SavemenuItem
            // 
            this.SavemenuItem.Index = 1;
            this.SavemenuItem.Text = "&Save";
            this.SavemenuItem.Click += new System.EventHandler(this.SavemenuItem_Click);
            // 
            // RestartmenuItem
            // 
            this.RestartmenuItem.Index = 2;
            this.RestartmenuItem.Text = "&ReStart";
            this.RestartmenuItem.Click += new System.EventHandler(this.RestartmenuItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "-";
            // 
            // ExitmenuItem
            // 
            this.ExitmenuItem.Index = 4;
            this.ExitmenuItem.Text = "E&xit";
            this.ExitmenuItem.Click += new System.EventHandler(this.ExitmenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.sav";
            this.openFileDialog.FileName = "wombat.sav";
            this.openFileDialog.Filter = "sav files (*.sav)|*.sav|All files (*.*)|*.*";
            this.openFileDialog.InitialDirectory = ".";
            this.openFileDialog.Title = "Load a saved game";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "*.sav";
            this.saveFileDialog.FileName = "wombat.sav";
            this.saveFileDialog.Filter = "sav files (*.sav)|*.sav|All files (*.*)|*.*";
            this.saveFileDialog.InitialDirectory = ".";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(555, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayTB);
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Adventure Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.ComponentModel.IContainer components;
    }
}
