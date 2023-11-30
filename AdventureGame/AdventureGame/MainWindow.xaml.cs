using System;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Specialized;

namespace game {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Adventure adv; // the Adventure object

        public MainWindow() {
            InitializeComponent();
            InitAdventure();
        }

        private void Wr(String s) {
            // utility method to append text to textbox           
            displayTB.AppendText(s);                             
            displayTB.ScrollToEnd();
        }

        private void WrLn(String s) {
            // simple utility method that appends carriage-return/linefeed before caling Wr()
            Wr(s);
            Wr("\r\n");
        }

        private void InitAdventure() {
            // create adventure and describe current room
            adv = new Adventure();
            displayTB.Clear();
            ShowLocation();
        }

        private void ShowLocation() {
            Wr(adv.Player.Name);
            Wr(" are currently in this room: ");
            WrLn(adv.Player.CurrentRoom.Describe());
        }

        private void ShowInventory() {
            WrLn("You have " + adv.Player.Things.Describe());
        }

        private void MovePlayer(Dir aDir) {
            WrLn(adv.MovePlayerTo(aDir));
        }

        private void LoadmenuItem_Click(object sender, RoutedEventArgs e) {
            Stream st;
            BinaryFormatter binfmt;
            OpenFileDialog openFileDialog = new OpenFileDialog() {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "sav files (*.sav)|*.sav|All files (*.*)|*.*",
                DefaultExt = ".sav",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            bool? result = openFileDialog.ShowDialog();
            if (result == true) {
                if ((st = openFileDialog.OpenFile()) != null) {
                    binfmt = new BinaryFormatter();
                    adv = (Adventure)binfmt.Deserialize(st);
                    st.Close();
                }
            }
            displayTB.Clear();
            ShowLocation();         
        }

        private void SavemenuItem_Click(object sender, RoutedEventArgs e) {
            Stream st;
            BinaryFormatter binfmt;
            SaveFileDialog saveFileDialog = new SaveFileDialog() {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "sav files (*.sav)|*.sav|All files (*.*)|*.*",
                DefaultExt = ".sav",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            bool? result = saveFileDialog.ShowDialog();
            if (result == true) {
                if ((st = saveFileDialog.OpenFile()) != null) {
                    // Save to disk
                    binfmt = new BinaryFormatter();
                    binfmt.Serialize(st, adv);
                    st.Close();
                    WrLn("Saved");
                }
            }

        }

        private void TestBtn_Click(object sender, RoutedEventArgs e) {
            WrLn("xx");
            WrLn("yy");

        }

        private void NBtn_Click(object sender, RoutedEventArgs e) {
            MovePlayer(Dir.NORTH);
        }

        private void SBtn_Click(object sender, RoutedEventArgs e) {
            MovePlayer(Dir.SOUTH);
        }

        private void WBtn__Click(object sender, RoutedEventArgs e) {
            MovePlayer(Dir.WEST);
        }

        private void EBtn_Click(object sender, RoutedEventArgs e) {
            MovePlayer(Dir.EAST);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            ShowLocation();
        }

        private void InvBtn_Click(object sender, RoutedEventArgs e) {
            ShowInventory();
        }

        private void TakeBtn_Click(object sender, RoutedEventArgs e) {
            WrLn(adv.TakeOb(inputTB.Text));
        }

        private void DropBtn_Click(object sender, RoutedEventArgs e) {
            WrLn(adv.DropOb(inputTB.Text));
        }

        private void LookAtBtn_Click(object sender, RoutedEventArgs e) {
            WrLn(adv.LookAtOb(inputTB.Text));
        }

        private void RestartmenuItem_Click(object sender, RoutedEventArgs e) {
            InitAdventure();
        }

        private void ExitmenuItem_Click(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}
