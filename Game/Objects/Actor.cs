namespace greed.Game.Objects
{

    public class Actor //Tyler - I made it public so Keyboard Service can access your class
    {
        //attributes
        int location_x;
        int location_y;
        int color;
        string character;

        //constructor
        public void actorConstructor(int location_x, int location_y, int color, string character)
        {
            this.location_x = location_x;
            this.location_y = location_y;
            this.color = color;
            this.character = character;
        }
        
        //methods
        public int getLocationX()
        {
            return this.location_x;
        }
        
        public int getLocationY()
        {
            return this.location_y;
        }

        public int getColor()
        {
            return this.color;
        }

        public void shiftLocation(int x, int y)
        {
            this.location_x += x;
            this.location_y += y;
        }

        public string getCharacter()
        {
            return this.character;
        }
    }
}
