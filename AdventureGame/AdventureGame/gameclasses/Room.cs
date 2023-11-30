using System;

namespace game.gameclasses
{
    // ==========================================================
    // class Room
    // ==========================================================
    [Serializable]
    public class Room : ThingHolder
    {
        private int _n, _s, _w, _e;

        public Room(string aName, string aDescription, int aN, int aS, int aW, int aE, ThingList tl)
            : base(aName, aDescription, tl)
        {
            _n = aN;
            _s = aS;
            _w = aW;
            _e = aE;
        }

        public int N
        {
            get => _n;
            set => _n = value;
        }

        public int S
        {
            get => _s;
            set => _s = value;
        }

        public int W
        {
            get => _w;
            set => _w = value;
        }

        public int E
        {
            get => _e;
            set => _e = value;
        }

        public void SetDirs(int aN, int aS, int aW, int aE)
        {
            _n = aN;
            _s = aS;
            _w = aW;
            _e = aE;
        }

        public void GetDirs(out int aN, out int aS, out int aW, out int aE)
        {
            aN = _n;
            aS = _s;
            aW = _w;
            aE = _e;
        }

        public override string Describe()
        {
            return String.Format("\tName: {0}\r\n\tDescription: {1}.", Name, Description)
                    + "\r\n\tThings here: " + this.Things.Describe() + "\r\n";
        }
    } // Room
}
