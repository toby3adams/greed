namespace greed.Game.Objects
{
    class Gem : Actor
    {
        //construct the player using initial values of location, color, and character

        private int Color =0;
        private int FallSpeed = -1;

        public Gem()
        {
            Random random = new Random();
            int RandColor=random.Next(0,100);

            if (RandColor >= 25)                                //**NEED TO CHANGE COLORS TO CORRECT INTS**\\
            { //Green 
                Color = 1;              // RGB 0,255,0
            }
            else if (RandColor<=75)
            { //White
                Color = 2;              //RGB 255,255,255
                FallSpeed = -15;
            }
            else if (RandColor<=50)
            { //Red
                Color = 3;              //RGB 255, 0, 0
                FallSpeed = -10;
            }
            else if (RandColor<=25)
            { //Blue
                Color = 4;
                FallSpeed = -5;
            }
            actorConstructor(0, 0, RandColor, "*"); //Zak- Make sure to adjust the y location to the top of the screen.
            
            int x = random.Next(0, 10); //Zak- make sure to adjust the range to be within the bounds of the screen.
            shiftLocation(x, 0); //Zak-this will move the rock to the random x location
        }
    }
}