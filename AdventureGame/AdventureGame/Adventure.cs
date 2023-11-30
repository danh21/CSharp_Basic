using System;
using game.gameclasses;



namespace game
{
    /// <summary>
    /// The Adventure class contains the 'world' of the game:
    /// the player and any other actors, plus the map.
    /// </summary>
    /// 
    [Serializable]
    public class Adventure
    {
        private Actor _player;
        private RoomList _map = new RoomList();
        private const int NOEXIT = -1;



        public Adventure()
        {
            // CONSTRUCT GAME
            //					
            // -- add some things to an object
            ThingList rm0list = new ThingList();
            rm0list.Add(new Thing("carrot", "It is a very crunchy carrot"));

            ThingList rm2list = new ThingList();
            rm2list.Add(new Thing("sausage", "It is a plump pork sausage"));

            ThingList rm9list = new ThingList();
            rm9list.Add(new Thing("scrap of paper", "Someone has written a message on the scrap of paper using a blunt pencil. It says 'This space is intentionally left blank'"));
            rm9list.Add(new Thing("pencil", "This pencil is so blunt that it can no longer be used to write."));

            ThingList rm10list = new ThingList();
            rm10list.Add(new Thing("door", "It is a wooden door. There is a sign on it.", false));
            rm10list.Add(new Thing("sign", "The sign says: Notice to all wombats - Squeak once to open door.", false));

            // Kennel (ThingHolder) containing a wombat
            ThingList kennelcontents = new ThingList();
            kennelcontents.Add(new Thing("wombat", "It's a cuddly little wombat. It is squeaking gently to itself."));

            ThingList rm12list = new ThingList();
            rm12list.Add(new Thing("sign", "The sign says: 'Do not feed the wombat!'", false));
            ThingHolder kennel = new ThingHolder("kennel", "This kennel is about the right size for a wombat!", false, kennelcontents); // false = cannot take!			
            rm12list.Add(kennel);

            ThingList rm13list = new ThingList();
            rm13list.Add(new Thing("toad", "It is a slimy toad that keeps saying 'greep-greep! greep-greep!'"));

            ThingList rm15list = new ThingList();
            rm15list.Add(new Thing("ring of power", "It is a golden ring that seems to pulse with hidden power"));

            // -- create map														   /N, S, W, E */
            /* 0 */
            _map.Add(new Room("Meadow", "A beautiful grassy meadow.", NOEXIT, 1, NOEXIT, NOEXIT, rm0list));
            /* 1 */
            _map.Add(new Room("Forest", "A gloomy forest that smells strongly of pine.", 0, 3, 3, 2, new ThingList()));
            /* 2 */
            _map.Add(new Room("Glade", "A sunny forest glade.", NOEXIT, 4, 1, NOEXIT, rm2list));
            /* 3 */
            _map.Add(new Room("Grassy Hill", "A grassy mound. You can see a forest stretching away to the North and West. A precipitous cliff face drops away to the South.", 1, NOEXIT, 1, 4, new ThingList()));
            /* 4 */
            _map.Add(new Room("Cave", "A dank, dripping cave.", 2, NOEXIT, 3, 5, new ThingList()));
            /* 5 */
            _map.Add(new Room("Passage", "A maze of twisty little passages, all alike.", 9, 6, 4, 7, new ThingList()));
            /* 6 */
            _map.Add(new Room("Cavern", "A vast cavern that stretches away into the far distance.", 5, 8, NOEXIT, 8, new ThingList()));
            /* 7 */
            _map.Add(new Room("Passage", "A maze of twisty little passages, all alike.", 7, 8, 5, 8, new ThingList()));
            /* 8 */
            _map.Add(new Room("Passage", "A maze of twisty little passages, all alike.", 7, 6, 6, 7, new ThingList()));
            /* 9 */
            _map.Add(new Room("Field", "A dismal field covered in dry, brown grass.", 10, 5, NOEXIT, 12, rm9list));
            /* 10 */
            _map.Add(new Room("Gateway", "A mighty stone gateway with a big wooden gate (shut).", NOEXIT, 9, NOEXIT, NOEXIT, rm10list));
            /* 11 */
            _map.Add(new Room("Avenue", "An imposing ceremonial avenue lines with poplars. There is a mighty stone gateway to the South and a huge dome of shimmering crystal to the North.", 14, 10, 13, NOEXIT, new ThingList()));
            /* 12 */
            _map.Add(new Room("Kennel Room", "A small stone-walled room.", NOEXIT, NOEXIT, 9, NOEXIT, rm12list));
            /* 13 */
            _map.Add(new Room("Garden", "A beautiful scented garden. At its northern edge stands a magnificent golden dome.", 15, NOEXIT, NOEXIT, 11, rm13list));
            /* 14 */
            _map.Add(new Room("Crystal Dome", "A vast glittering crystal dome.", NOEXIT, 11, 15, NOEXIT, new ThingList()));
            /* 15 */
            _map.Add(new Room("Golden Dome", "A great golden dome ornamented with arabesques of Lapis lazuli.", NOEXIT, 13, NOEXIT, 14, new ThingList()));

            // -- add player to room0
            _player = new Actor("You", "The Player", _map.RoomAt(0), new ThingList());
        }



        //// --- Player
        public Actor Player
        {
            get
            {
                return _player;
            }
        } // Player



        // ========= Special Actions that control the game ==========
        //
        private void MoveActorTo(Actor anActor, Room aRoom)
        {
            anActor.CurrentRoom = aRoom;
        }


        private int MoveTo(Actor anActor, Dir direction)
        {
            Room r = anActor.CurrentRoom;
            int exit;

            switch (direction)
            {
                case Dir.NORTH:
                    exit = r.N;
                    break;
                case Dir.SOUTH:
                    exit = r.S;
                    break;
                case Dir.EAST:
                    exit = r.E;
                    break;
                case Dir.WEST:
                    exit = r.W;
                    break;
                default:
                    exit = NOEXIT;
                    break;
            }

            if (exit != NOEXIT)
            {
                MoveActorTo(anActor, _map.RoomAt(exit));
            }

            return exit;
        }


        // returns string msg to display after attempting moveTo() operation
        public string MovePlayerTo(Dir direction) 
        {
            string s = "";

            if (MoveTo(_player, direction) == NOEXIT)
            {
                s = Msg.NOEXIT;
            }
            else
            {
                s = _player.CurrentRoom.Describe();
            }

            return s;
        }


        private void TransferOb(Thing t, ThingList fromlist, ThingList tolist)
        {
            fromlist.Remove(t);
            tolist.Add(t);
        }


        public string TakeOb(string obname)
        {
            Thing t = _player.CurrentRoom.Things.ThisOb(obname);
            string s;

            if (obname == "")
            {
                obname = "nameless object"; // if no specified object 
            }

            if (t == null)
            {
                s = "There is no " + obname + " here!";
            }
            else
            {
                if (t.CanTake)
                {
                    TransferOb(t, _player.CurrentRoom.Things, _player.Things);
                    s = t.Name + " taken!";
                }
                else
                {
                    s = "You can't take the " + t.Name + "!";
                }
            }

            return s;
        }


        // TODO: Let each object respond with any special actions rather than use this method!!!
        private string DropObSpecialAction(Thing t, Room r)
        {
            string s = "";
            if ((t.Name == "carrot") && (r.Name == "Kennel Room"))
            {
                // TODO: Create a puzzle. If the player drops the carrot here, 
                // the wombat comes out of kennel and eats carrot (once you've coded this!).
                s = "If you want the wombat to come out, you'll have to do some coding first!!!!";
            }
            return s;
        }

        public string DropOb(string obname)
        {
            Thing t = _player.Things.ThisOb(obname);
            string s;

            if (t == null)
            {
                s = "You haven't got one!";
            }
            else
            {
                TransferOb(t, _player.Things, _player.CurrentRoom.Things);
                s = t.Name + " dropped!" + DropObSpecialAction(t, _player.CurrentRoom); // check for any special actions ;
            }

            return s;
        }

        public string LookAtOb(string obname)
        {
            Thing t;
            string s;

            if (obname == "")
            {
                s = "You'll have to say what you want to look at!";
            }
            else
            {
                t = _player.CurrentRoom.Things.ThisOb(obname);

                if (t == null)
                {
                    t = _player.Things.ThisOb(obname);
                }

                if (t == null)
                {
                    s = "There is no " + obname + " here!";
                }
                else
                {
                    s = t.Description + ".";
                }
            }

            return s;
        }

    } // Adventure
}
