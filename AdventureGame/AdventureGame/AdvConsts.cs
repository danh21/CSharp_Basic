namespace game
{
    /// <summary>
    /// AdventureConstants contains classes that
    /// define any constants that might be needed
    /// 'globally' throughout the game.
    /// </summary>
    ///     

    public enum Dir {
        NORTH,
        SOUTH,
        EAST,
        WEST
    }

    public class Msg {
        public const string NOEXIT = "No Exit";
        // TODO: Define more message constants

        private Msg() {
            // constructor is private so a msg object
            // cannot be created using 'new'
        }
    }
}
