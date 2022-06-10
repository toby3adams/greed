using Raylib_cs;
using greed.Game.Objects;

namespace greed.Game.Services
{
    public class KeyboardServices
    {

        private int ScaleingFactor = 1; // The Scaling Factor is a variable used to represent th size of the cell of the GUI
        //This value is used so that when the player moves it will move faster as it will increase the amount of pixels moved
        //by the player.
        public KeyboardServices(int Factor) { //** we may be able to use this to add and ability to increase speed.
            this.ScaleingFactor = Factor;
        }

        public int PlayerDirection() //Uses the principles of inheritance to call the Object class so that the returned 
        //value will be initialized in the Object class
        {
            int XCoordinate = 0;

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) { //if the Right Arrow is pressed it will add a 1 to move the player right
                XCoordinate = 1;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) { //if the Left Arrow is pressed it will add a -1 to move the player left // Doug - changed this from KEY_RIGHT to KEY_LEFT 6/8 2115hrs
                XCoordinate = -1;
            }

            //Point direction = new Point(XCoordinate, YCoordinate);
            int direction = XCoordinate * ScaleingFactor;

            return direction;    
        }



    }







}