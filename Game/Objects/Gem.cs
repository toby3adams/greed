using greed.Game.Services;

namespace greed.Game.Objects
{
    class Gem : Actor
    {
        //construct the player using initial values of location, color, and character

        private int gem_color =0;
        private int Speed = 0;

        public Gem()
        {
            Random random = new Random();
            int RandColor=random.Next(0,4);

            if (RandColor == 0 )                                
            { //White
                this.gem_color = 1;   
                this.FallSpeed = 7;
                this.value = 150;           
            }
            else if (RandColor==1)
            { //Red
                gem_color = 3;              
                this.FallSpeed = 6;
                this.value = 100;
            }
            else if (RandColor==2)
            { //Green
                gem_color = 4;              
                this.FallSpeed = 5;
                this.value = 80;
            }
            else if (RandColor==3)
            { //Blue
                gem_color = 5;
                this.FallSpeed = 4;
                this.value = 60;
            }
            
            actorConstructor(0, 0, gem_color, "*"); //Zak- Make sure to adjust the y location to the top of the screen.           
            int x = random.Next(0, 625); //Zak- make sure to adjust the range to be within the bounds of the screen.
            shiftLocation(x, 0); //Zak-this will move the rock to the random x location

            Actor actor = new Actor();
            actor.FallSpeed = this.Speed;
        }
    }
}