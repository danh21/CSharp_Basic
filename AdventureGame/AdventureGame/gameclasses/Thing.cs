using System;

namespace game.gameclasses
{
    /// <summary>
    /// AdventureThing contains a hierarchy of the
    /// essential object types of an adventure game
    /// such as Treasure, Room and Player
    /// </summary>
    ///

    /* Base classes that define the Things in this game */

    // ==========================================================
    // class Thing
    // ==========================================================
    [Serializable]
    public class Thing
    {   // the basic Thing from which all Adventure
        // objects descend.

        private string _name;
        private string _description;
        private bool _cantake;

        public Thing(string aName, string aDescription)
        {
            // standard constructor: 
            _name = aName;
            _description = aDescription;
            _cantake = true;        // sets _cantake to default value
        }

        public Thing(string aName, string aDescription, bool aCantake)
        {
            // alternative constructor
            _name = aName;
            _description = aDescription;
            _cantake = aCantake;
        }

        public string Name          //  Name property
        {
            get => _name;
            set => _name = value;
        }

        public string Description   // Description property
        {
            get => _description;
            set => _description = value;
        }

        public bool CanTake
        {
            get => _cantake;
            set => _cantake = value;
        }

        public virtual string Describe() //!! note this is a virtual method
        {
            return Name + " - " + Description;
        }

    } // Thing
}
