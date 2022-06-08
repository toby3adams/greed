namespace greed.Game.Objects
{
    class Player: Actor
    {
        //construct the player using initial values of location, color, and character
        public Player()
        {
        actorConstructor(0, 0, 256, "#"); //Zak --starts the player at (0,0) !!! adjust as needed to start the player to start position !!!
        }
    }
}