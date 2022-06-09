using greed.Game.Services;

namespace greed.Game.Objects
{
    class Gem : Actor
    {
        //construct the player using initial values of location, color, and character

        private int Color =0;
        private int Speed = -1;

        public Gem()
        {
            Random random = new Random();
            int RandColor=random.Next(0,4);

            if (RandColor == 0 )                                
            { //White
                Color = 1;              
            }
            else if (RandColor==1)
            { //Red
                Color = 3;              
                this.Speed = -15;
            }
            else if (RandColor==2)
            { //Green
                Color = 4;              
                this.Speed = -10;
            }
            else if (RandColor==3)
            { //Blue
                Color = 5;
                this.Speed = -5;
            }
            
            actorConstructor(0, 0, Color, "*"); //Zak- Make sure to adjust the y location to the top of the screen.

            //ToRaylibColor(Color);
            
            int x = random.Next(0, 625); //Zak- make sure to adjust the range to be within the bounds of the screen.
            shiftLocation(x, 0); //Zak-this will move the rock to the random x location
            Actor actor = new Actor();
            actor.FallSpeed = this.Speed;
        }
    }
}