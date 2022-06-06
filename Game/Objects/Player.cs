namespace objects
{
    class player: objectProperties
    {
        //construct the player using initial values of location, color, and character
        public player(int location_x, int location_y, int color, char character)
            : base(location_x, location_y, color, #){}
    }
}