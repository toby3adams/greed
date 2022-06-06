namespace greed.Game.Objects
{
    class player: objectProperties
    {
        //construct the player using initial values of location, color, and character
        public player() : base(objectProperties)
        {
            objectconstructor(0, 0, 256, '#'); //Zak- starts the player at (0,0) !!!!!adjust this to the proper value when known!!!!!
        }
    }
}