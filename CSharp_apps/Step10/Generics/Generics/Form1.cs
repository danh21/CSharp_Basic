using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Generics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public List<Thing> thingList = new List<Thing>();
        public Dictionary<string, Room> roomDictionary = new Dictionary<string, Room>();



        public class Thing
        {
            public string name;
            public string description;

            public Thing(string aName, string aDescription)
            {
                name = aName;
                description = aDescription;
            }
        }



        public class Room
        {
            public string description;

            public Room(string aDescription)
            {
                description = aDescription;
            }
        }



        private void listBtn_Click(object sender, EventArgs e)
        {
            if (thingList.Count == 0)
            {
                thingList.Add(new Thing("Sword", "An Elvish weapon"));
                thingList.Add(new Thing("Lantern", "(giving light)"));
                thingList.Add(new Thing("Ring", "A golden ring"));
            }
            else
            {
                textBox1.AppendText("\r\nthingList isn't empty");
            }
        }



        private void dictionaryBtn_Click(object sender, EventArgs e)
        {
            if (roomDictionary.Count == 0)
            {
                roomDictionary.Add("Troll Room", new Room("A dank cave"));
                roomDictionary.Add("Lair", new Room("A glittering Dragon's Lair"));
                roomDictionary.Add("House", new Room("A small and cosy cottage"));
            }
            else
            {
                textBox1.AppendText("\r\nroomDictionary isn't empty");
            }
        }



        private void addBtn_Click(object sender, EventArgs e)
        {
            thingList.Add(new Thing("New Thing", "A new treasure"));
            if (!roomDictionary.ContainsKey("New Room"))
                roomDictionary.Add("New Room", new Room("A lovely new room"));
        }



        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string searchname = nameTB.Text;

            if (roomDictionary.ContainsKey(searchname))
            {
                roomDictionary.Remove(searchname);
                textBox1.AppendText("\r\n" + searchname + " is removed from roomDictionary!\r\n");
            }
            else
            {
                textBox1.AppendText("\r\n" + searchname + " is not found in roomDictionary!\r\n");
            }

            for (int i = 0; i < thingList.Count; i++)
            {
                if (thingList[i].name == searchname)
                {
                    thingList.RemoveAt(i);
                    textBox1.AppendText("\r\n" + searchname + " is removed from thingList.\r\n");
                    break;
                }
            }
        }


        private void showBtn_Click(object sender, EventArgs e)
        {
            string s = "---Things---\r\n";
            foreach (Thing th in thingList)
            {
                s += String.Format("{0}: {1}\r\n", th.name, th.description);
            }

            s += "\r\n---Rooms---\r\n";
            foreach (KeyValuePair<string, Room> kvp in roomDictionary)
            {
                s += String.Format("{0}: {1}\r\n", kvp.Key, kvp.Value.description);
            }

            textBox1.Text = s;
        }
    }
}
