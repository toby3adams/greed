namespace greed.Game.Objects
{
    class Rock : Actor
    {
        //construct the player using initial values of location, color, and character
        public int Speed = 8;
        public Rock()
        {

            actorConstructor(0, 0, 2, "@"); //Zak- Make sure to adjust the y location to the top of the screen.
            Random random = new Random();
            int x = random.Next(0, 625); //Zak- make sure to adjust the range to be within the bounds of the screen.
            shiftLocation(x, 0); //Zak-this will move the rock to the random x location
            this.value = -100;
            this.FallSpeed = Speed;
        }
    }
}