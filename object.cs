namespace objects
{
    class object
    {
        //attributes
        int location_x;
        int location_y;
        int color;

        //constructor
        public object(int location_x, int location_y, int color)
        {
            this.location_x = location_x;
            this.location_y = location_y;
            this.color = color;
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
    }
}
