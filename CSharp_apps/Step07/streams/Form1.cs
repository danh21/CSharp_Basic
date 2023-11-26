using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO; // NEEDED FOR STREAMS

// NOTE: This code assumes that you have a directory
// C:\Test containing a file named test.txt
namespace streams
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        static string currDir = Directory.GetCurrentDirectory();

        string SOURCEFN = currDir + "\\..\\..\\test\\test.txt";

        const int BUFFSIZE = 1024;

        private System.Windows.Forms.Button FileStreamBtn;
        private System.Windows.Forms.Button StreamWriterBtn;
        private System.Windows.Forms.Button BuffStreamWriteBtn;
        private System.Windows.Forms.Button WriteStreamBtn;
        private System.Windows.Forms.Button AppendBtn;
        private Button FileTestBtn;
        private TextBox textBox1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StreamWriterBtn = new System.Windows.Forms.Button();
            this.FileStreamBtn = new System.Windows.Forms.Button();
            this.BuffStreamWriteBtn = new System.Windows.Forms.Button();
            this.WriteStreamBtn = new System.Windows.Forms.Button();
            this.AppendBtn = new System.Windows.Forms.Button();
            this.FileTestBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StreamWriterBtn
            // 
            this.StreamWriterBtn.Location = new System.Drawing.Point(90, 199);
            this.StreamWriterBtn.Name = "StreamWriterBtn";
            this.StreamWriterBtn.Size = new System.Drawing.Size(217, 33);
            this.StreamWriterBtn.TabIndex = 2;
            this.StreamWriterBtn.Text = "StreamWriter";
            this.StreamWriterBtn.Click += new System.EventHandler(this.StreamWriterBtn_Click);
            // 
            // FileStreamBtn
            // 
            this.FileStreamBtn.Location = new System.Drawing.Point(90, 105);
            this.FileStreamBtn.Name = "FileStreamBtn";
            this.FileStreamBtn.Size = new System.Drawing.Size(217, 34);
            this.FileStreamBtn.TabIndex = 1;
            this.FileStreamBtn.Text = "Write FileStream";
            this.FileStreamBtn.Click += new System.EventHandler(this.FileStreamBtn_Click);
            // 
            // BuffStreamWriteBtn
            // 
            this.BuffStreamWriteBtn.Location = new System.Drawing.Point(90, 58);
            this.BuffStreamWriteBtn.Name = "BuffStreamWriteBtn";
            this.BuffStreamWriteBtn.Size = new System.Drawing.Size(217, 34);
            this.BuffStreamWriteBtn.TabIndex = 0;
            this.BuffStreamWriteBtn.Text = "Write Buffered Stream";
            this.BuffStreamWriteBtn.Click += new System.EventHandler(this.BuffStreamWriteBtn_Click);
            // 
            // WriteStreamBtn
            // 
            this.WriteStreamBtn.Location = new System.Drawing.Point(90, 12);
            this.WriteStreamBtn.Name = "WriteStreamBtn";
            this.WriteStreamBtn.Size = new System.Drawing.Size(217, 33);
            this.WriteStreamBtn.TabIndex = 3;
            this.WriteStreamBtn.Text = "Write Stream";
            this.WriteStreamBtn.Click += new System.EventHandler(this.WriteStreamBtn_Click);
            // 
            // AppendBtn
            // 
            this.AppendBtn.Location = new System.Drawing.Point(90, 152);
            this.AppendBtn.Name = "AppendBtn";
            this.AppendBtn.Size = new System.Drawing.Size(217, 34);
            this.AppendBtn.TabIndex = 4;
            this.AppendBtn.Text = "Append Text";
            this.AppendBtn.Click += new System.EventHandler(this.AppendBtn_Click);
            // 
            // FileTestBtn
            // 
            this.FileTestBtn.Location = new System.Drawing.Point(90, 243);
            this.FileTestBtn.Name = "FileTestBtn";
            this.FileTestBtn.Size = new System.Drawing.Size(217, 33);
            this.FileTestBtn.TabIndex = 5;
            this.FileTestBtn.Text = "File Test";
            this.FileTestBtn.UseVisualStyleBackColor = true;
            this.FileTestBtn.Click += new System.EventHandler(this.FileTestBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(528, 258);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(957, 335);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FileTestBtn);
            this.Controls.Add(this.AppendBtn);
            this.Controls.Add(this.WriteStreamBtn);
            this.Controls.Add(this.StreamWriterBtn);
            this.Controls.Add(this.FileStreamBtn);
            this.Controls.Add(this.BuffStreamWriteBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void WriteStreamBtn_Click(object sender, System.EventArgs e)
        {
            // Use Stream objects to write bytes            
            string OUTPUTFN = currDir + "\\..\\..\\test\\Stream.txt";

            Stream instream = File.OpenRead(SOURCEFN);
            Stream outstream = File.OpenWrite(OUTPUTFN);

            byte[] buffer = new byte[BUFFSIZE];
            int numbytes;
            while ((numbytes = instream.Read(buffer, 0, BUFFSIZE)) > 0)
            {
                outstream.Write(buffer, 0, numbytes);
            }

            instream.Close();
            outstream.Close();
        }

        private void BuffStreamWriteBtn_Click(object sender, System.EventArgs e)
        {
            // Use Stream objects and buffers to write bytes            
            string OUTPUTFN = currDir + "\\..\\..\\test\\BuffStream.txt";

            Stream instream = File.OpenRead(SOURCEFN);
            Stream outstream = File.OpenWrite(OUTPUTFN);

            BufferedStream buffInput = new BufferedStream(instream);
            BufferedStream buffOutput = new BufferedStream(outstream);

            byte[] buffer = new byte[BUFFSIZE];
            int numbytes;
            while ((numbytes = buffInput.Read(buffer, 0, BUFFSIZE)) > 0)
            {
                buffOutput.Write(buffer, 0, numbytes);
            }

            // buffOutput.Flush(); // not needed here: Close() flushes data
            buffInput.Close();
            buffOutput.Close();
        }

        private void FileStreamBtn_Click(object sender, System.EventArgs e)
        {
            // use FileStream object to write Bytes
            string OUTPUTFN = currDir + "\\..\\..\\test\\FileStream.txt";

            FileStream instream = new FileStream(SOURCEFN,
                FileMode.OpenOrCreate, FileAccess.Read);
            FileStream outstream = new FileStream(OUTPUTFN,
                FileMode.OpenOrCreate, FileAccess.Write);

            byte[] buffer = new byte[BUFFSIZE];
            int bytesRead;
            while ((bytesRead = instream.Read(buffer, 0, BUFFSIZE)) > 0)
            {
                outstream.Write(buffer, 0, bytesRead);
            }

            instream.Close();
            outstream.Close();
        }

        private void StreamWriterBtn_Click(object sender, System.EventArgs e)
        {
            // StreamWriter object to write lines of text
            string OUTPUTFN = currDir + "\\..\\..\\test\\StreamWriter.txt";
            StreamReader sread;
            StreamWriter swrite;
            string aline;
            
            if (!File.Exists(SOURCEFN))
            {
                MessageBox.Show(SOURCEFN + " does not exist!", "File not found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sread = File.OpenText(SOURCEFN);
                swrite = File.CreateText(OUTPUTFN);
                while ((aline = sread.ReadLine()) != null)
                {
                    swrite.WriteLine(aline);
                }
                sread.Close();
                swrite.Close();
            }
        }

        private void AppendBtn_Click(object sender, System.EventArgs e)
        {
            string OUTPUTFN = currDir + "\\..\\..\\test\\FileStream.txt";
            StreamReader sread;
            StreamWriter swrite;
            string aline;

            if (!File.Exists(SOURCEFN))
            {
                MessageBox.Show(SOURCEFN + " does not exist!", "File not found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!File.Exists(OUTPUTFN))
            {
                MessageBox.Show(OUTPUTFN + " does not exist!", "File not found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sread = File.OpenText(SOURCEFN);
                swrite = File.AppendText(OUTPUTFN); //!!
                while ((aline = sread.ReadLine()) != null)
                {
                    swrite.WriteLine(aline);
                }
                sread.Close();
                swrite.Close();
            }
        }

        private void FileTestBtn_Click(object sender, EventArgs e)
        {
            string testFile = currDir + "\\..\\..\\test\\test.txt";
            string testCopyFile = currDir + "\\..\\..\\test\\test_copy.txt";
            DateTime dtCreated;
            DateTime dtModified;

            textBox1.Clear();

            if (File.Exists(testFile))
            {
                textBox1.AppendText(testFile + " exists. Copying...\n");
                File.Copy(testFile, testCopyFile, true);
            }
            else
            {
                textBox1.AppendText(testFile + " does not exist\n");
            }

            // test a File exists before trying to do something with it!
            if (File.Exists(testFile))
            {
                dtCreated = File.GetCreationTime(testFile);
                dtModified = File.GetLastWriteTime(testFile);
                textBox1.AppendText(testFile + " was created at: " + dtCreated + "\n");
                textBox1.AppendText(testFile + " was modified at: " + dtModified);
            }
        }
    }
}
