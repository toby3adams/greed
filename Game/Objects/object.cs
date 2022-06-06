namespace objects
{
    public class objectProperties //Tyler - I made it public so Keyboard Service can access your class
    {
        //attributes
        int location_x;
        int location_y;
        int color;
        int character;

        //constructor
        public objectconstructor(int location_x, int location_y, int color, char character)
        {
            this.location_x = location_x;
            this.location_y = location_y;
            this.color = color;
            this.character = character;
        }
        
        //methods
        public int getLocationX()
        {
            return location_x;
        }
        
        public int getLocationY()
        {
            return location_y;
        }

        public int getColor()
        {
            return color;
        }


        // TYLER ADDED THIS. this class allows me to pass your object class back into its self while increasing the speed of the player to update the players location. 
        public objectProperties Factoring(int factor)// the factor is used to increase the speed of the player. Increase the amount of pixels moved.
        {
            int x = this.location_x * factor;
            int y = this.location_y * factor;// we may need to set the y coord to a fixed point.
    
            return new objectProperties(x, y, 256); // We will need to talk about color and how I can implement it.
            // we could make it so that as you move away from the center your color changes.
            // do we know the center point? // Or if we touch a gem or rock the player will flash a color? 
        }
    }
}
