using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameClasses {
    public partial class Form1 : Form {
        public Form1( ) {
            InitializeComponent( );
        }

        private void creatObjectsBtn_Click( object sender, EventArgs e ) {
            Thing th1;
            Thing th2;
            Treasure tr1;
            Treasure tr2;
            Room r1;
            Room r2;

            th1 = new Thing( "A thingummy: ", "A rather boring object" );
            th2 = new Thing( "A wotsit: ", "An object that does nothing" );
            tr1 = new Treasure( "An Elvish sword: ", "A magical weapon", 500 );
            tr2 = new Treasure( "An emerald ring: ", "A ring that glows in the dark", 750.50 );
            r1 = new Room( "Troll Room: ", "A dark and foul-smelling dungeon", 1, 4, 7, 8 );
            r2 = new Room( "Dragon's Lair: ", "A cave filled with treasure", 1, 4, 6, 3 );

            textBox1.Text = "Here this is...\r\n" +               
                th1.Name + th1.Description + "\r\n" +
                th2.Name + th2.Description + "\r\n" +
                tr1.Name + tr1.Description + " which is worth Gr" + tr1.Value + "\r\n" +
                tr2.Name + tr2.Description + " which is worth Gr" + tr1.Value + "\r\n" +
                "You can see the " + r1.Name + r1.Description + " with exits to " + r1.N + ", " + r1.S + ", " + r1.W + " and " + r1.E + "\r\nand " +
                r2.Name + r2.Description + " with exits to " + r2.N + ", " + r2.S + ", " + r2.W + " and " + r2.E + "\r\n";
        }
    }
}
