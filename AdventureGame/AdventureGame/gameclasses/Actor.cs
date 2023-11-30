using System;

namespace game.gameclasses
{
    // ==========================================================
    // class Actor
    // ==========================================================
    [Serializable]
    public class Actor : ThingHolder
    {
        private Room _room; // Room where Person is at present

        public Actor(string aName, string aDescription, Room aRoom, ThingList tl) : base(aName, aDescription, tl)
        {
            _room = aRoom;
        }

        public Room CurrentRoom
        {
            get => _room;
            set => _room = value;
        }
        public override string Describe()
        {
            return String.Format("Name: {0}, Description {1}", Name, Description) +
                "\r\nCurrently in this room: " + this.CurrentRoom.Describe();
        }
    }// Actor
}
