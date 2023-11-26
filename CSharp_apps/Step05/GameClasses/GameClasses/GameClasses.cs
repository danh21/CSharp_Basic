using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameClasses {
    class GameClasses {
    }

    public class Thing {
        private string _name;
        private string _description;

        public Thing( string aName, string aDescription ) {
            _name = aName;
            _description = aDescription;
        }

        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        public string Description {
            get {
                return _description;
            }
            set {
                _description = value;
            }
        }
    }

    public class Treasure : Thing {
        private double _value;

        public Treasure( string aName, string aDescription, double aValue )
            : base( aName, aDescription ) {
                _value = aValue;
        }

        public double Value {
            get {
                return _value;
            }
            set {
                _value = value;
            }
        }
    }

    public class Room : Thing {
        private int _n;
        private int _s;
        private int _w;
        private int _e;

        public Room( string aName, string aDescription, int aN, int aS, int aW, int anE ) 
            : base( aName, aDescription) {
                _n = aN;
                _s = aS;
                _w = aW;
                _e = anE;
        }


        public int N {
            get {
                return _n;
            }
            set {
                _n = value;
            }
        }
        

        public int S {
            get {
                return _s;
            }
            set {
                _s = value;
            }
        }
        

        public int W {
            get {
                return _w;
            }
            set {
                _w = value;
            }
        }
        

        public int E {
            get {
                return _e;
            }
            set {
                _e = value;
            }
        }

       

    }
}
