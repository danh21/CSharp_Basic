using System;
using System.Collections.Generic;



namespace game.gameclasses
{
    // ==========================================================
    // class ThingList
    // ==========================================================
    [Serializable]
    public class ThingList : List<Thing>
    {
        public string Describe()
        {
            string s = "";

            if (this.Count == 0)
            {
                s = "nothing.\r\n";
            }
            else
            {
                foreach (Thing t in this)
                {
                    s = s + t.Describe() + ";\t";
                }
            }

            return s;
        }


        public Thing ThisOb(string aName)
        {
            Thing athing = null;
            string thingName;
            string aNameLowCase = aName.Trim().ToLower();

            foreach (Thing t in this)
            {
                thingName = t.Name.Trim().ToLower();
                if (thingName.Equals(aNameLowCase))
                {
                    athing = t;
                }
            }

            return athing;
        }
    } // ThingList



    // ==========================================================
    // class RoomList
    // ==========================================================
    [Serializable]
    public class RoomList : List<Room>
    {
        public Room RoomAt(int Index)
        {
            return this[Index];
        }

        public string Describe()
        {
            string s = "";

            if (this.Count == 0)
            {
                s = "Nothing in RoomList.";
            }
            else
            {
                foreach (Room r in this)
                {
                    s = s + r.Describe() + "\r\n";
                }
            }

            return s;
        }
    } // RoomList
}