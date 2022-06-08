namespace greed.Game.Objects
{
    class rock : objectProperties
    {
        //construct the player using initial values of location, color, and character
        public rock()
        {
            objectconstructor(0, 0, 256, '@'); //Zak- Make sure to adjust the y location to the top of the screen.
            Random random = new Random();
            int x = random.Next(0, 10); //Zak- make sure to adjust the range to be within the bounds of the screen.
            shiftLocation(x, 0); //Zak-this will move the rock to the random x location
        }
    }
}