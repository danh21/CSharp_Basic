using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace game
{
    public partial class MainForm : Form
    {
        Adventure adv; // the Adventure object



        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }



        private void Wr(String s)
        {
            // utility method to append text to textbox
            displayTB.AppendText(s);
        }



        private void WrLn(String s)
        {
            // simple utility method that appends carriage-return/linefeed before caling Wr()
            Wr(s);
            Wr("\r\n");
        }



        private void InitAdventure()
        {
            // create adventure and describe current room
            adv = new Adventure();
            displayTB.Clear();
            ShowLocation();
        }



        private void TestBtn_Click(object sender, System.EventArgs e)
        {
            // an example of creating a file open dialog in code
            Stream st;

            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "sav files (*.sav)|*.sav|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((st = openFileDialog1.OpenFile()) != null)
                {
                    // File loading code would be added here
                    st.Close();
                }
            }
        }



        private void ShowLocation()
        {
            Wr(adv.Player.Name);
            WrLn(" are currently in this room: ");
            WrLn(adv.Player.CurrentRoom.Describe());
        }



        private void ShowInventory()
        {
            WrLn("You have " + adv.Player.Things.Describe());
        }



        private void MovePlayer(Dir aDir)
        {
            WrLn(adv.MovePlayerTo(aDir));
        }



        private void NorthBtn_Click(object sender, System.EventArgs e)
        {
            MovePlayer(Dir.NORTH);
        }



        private void SouthBtn_Click(object sender, System.EventArgs e)
        {
            MovePlayer(Dir.SOUTH);
        }



        private void WestBtn_Click(object sender, System.EventArgs e)
        {
            MovePlayer(Dir.WEST);
        }



        private void EastBtn_Click(object sender, System.EventArgs e)
        {
            MovePlayer(Dir.EAST);
        }



        private void LookBtn_Click(object sender, System.EventArgs e)
        {
            ShowLocation();
        }



        private void TakeBtn_Click(object sender, System.EventArgs e)
        {
            WrLn(adv.TakeOb(inputTB.Text));
        }



        private void DropBtn_Click(object sender, System.EventArgs e)
        {
            WrLn(adv.DropOb(inputTB.Text));
        }



        private void LookAtBtn_Click(object sender, System.EventArgs e)
        {
            WrLn(adv.LookAtOb(inputTB.Text));
        }



        private void SavemenuItem_Click(object sender, System.EventArgs e)
        {
            Stream st;
            BinaryFormatter binfmt;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((st = saveFileDialog.OpenFile()) != null)
                {
                    // Save to disk
                    binfmt = new BinaryFormatter();
                    binfmt.Serialize(st, adv);
                    st.Close();
                    WrLn("Saved");
                }
            }
        }



        private void LoadmenuItem_Click(object sender, System.EventArgs e)
        {
            Stream st;
            BinaryFormatter binfmt;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((st = openFileDialog.OpenFile()) != null)
                {
                    binfmt = new BinaryFormatter();
                    adv = (Adventure)binfmt.Deserialize(st);
                    st.Close();
                }
            }

            displayTB.Clear();
            ShowLocation();
        }



        private void RestartmenuItem_Click(object sender, System.EventArgs e)
        {
            InitAdventure();
        }



        private void ExitmenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }



        private void MainForm_Load(object sender, System.EventArgs e)
        { // create adventure on loading
            InitAdventure();
        }



        private void InvBtn_Click(object sender, System.EventArgs e)
        {
            ShowInventory();
        }
    }
}
