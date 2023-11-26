using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassesAndMore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string CRLF = "\r\n";

        private void test1Btn_Click(object sender, EventArgs e)
        {
            MyClass ob1;
            //  MyStaticClass ob2;
            ob1 = new MyClass("Hello World");
            //  ob2 = new MyStaticClass( ); // ERROR: Can't create object from static class!
            textBox1.AppendText(ob1.ToLowCase() + CRLF);
            textBox1.AppendText(ob1.ToReversedLowCase() + CRLF);
            textBox1.AppendText(MyClass.ToLowCase("ABc") + CRLF);
            textBox1.AppendText(MyClass.ToUppCase("abC") + CRLF);
            textBox1.AppendText(MyClass.Capitalize("hello world"));
        }



        private void structTestBtn_Click(object sender, EventArgs e)
        {
            MyPointStruct mypt;
            Point mypoint;
            mypt = new MyPointStruct(10, 20);
            mypoint = mypt.asPoint();
            textBox1.Text = "MyPointStruct x = " + mypt.X + " and MyPointStruct y = " + mypt.Y;
            textBox1.AppendText(CRLF + "Point x = " + mypoint.X + " and Point y = " + mypoint.Y);
        }

        private void enumTestBtn_Click(object sender, EventArgs e)
        {
            string suit = suitsComboBox.Text;
            CardSuits selectedSuit;
            switch (suit)
            {
                case "Clubs":
                    selectedSuit = CardSuits.Clubs;
                    break;
                case "Spades":
                    selectedSuit = CardSuits.Spades;
                    break;
                case "Hearts":
                    selectedSuit = CardSuits.Hearts;
                    break;
                case "Diamonds":
                    selectedSuit = CardSuits.Diamonds;
                    break;
                default:
                    selectedSuit = CardSuits.Unknown;
                    break;
            }
            textBox1.Text = selectedSuit.ToString();
        }

        private void cardEnumTestBtn_Click(object sender, EventArgs e)
        {
            string card = pictureCardsComboBox.Text;
            PictureCards selectedCard;
            switch (card)
            {
                case "Jack":
                    selectedCard = PictureCards.Jack;
                    break;
                case "Queen":
                    selectedCard = PictureCards.Queen;
                    break;
                case "King":
                    selectedCard = PictureCards.King;
                    break;
                default:
                    selectedCard = PictureCards.NotAPictureCard;
                    break;
            }
            textBox1.Text = "You picked " + card + " with the value: " + (int)selectedCard;

        }

        private void anchorTopRightBtn_Click(object sender, EventArgs e)
        {
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        private void anchorBottomLeftBtn_Click(object sender, EventArgs e)
        {
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void dockTopBtn_Click(object sender, EventArgs e)
        {
            textBox1.Dock = DockStyle.Top;
        }

        private void dockRightBtn_Click(object sender, EventArgs e)
        {
            textBox1.Dock = DockStyle.Right;
        }
    }
}
