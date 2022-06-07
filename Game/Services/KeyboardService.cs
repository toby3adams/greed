using Raylib_cs;
using greed.Game.Objects;

namespace services
{
    public class KeyboardServices
    {
        private int ScaleingFactor = 10; // The Scaling Factor is a variable used to represent th size of the cell of the GUI
        //This value is used so that when the player moves it will move faster as it will increase the amount of pixels moved
        //by the player.
        public KeyboardServices(int Factor) { //** we may be able to use this to add and ability to increase speed.
            this.ScaleingFactor = Factor;
        }

        public objectProperties PlayerDirection() //Uses the principles of inheritance to call the Object class so that the returned 
        //value will be initialized in the Object class
        {
            int XCoordinate = 0;

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) { //if the Right Arrow is pressed it will add a 1 to move the player right
                XCoordinate = 1;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) { //if the Left Arrow is pressed it will add a -1 to move the player left
                XCoordinate = -1;
            }

            (XCoordinate,200,15); // I need to talk to Zak about Y-COORDS AND COLOR. This will initialize the XCoordinate for the Player Character
            movement = movement.Factoring(ScaleingFactor); // New object initializes the values in the other class and then scales it and returns it
            // we set the movement to the new factor because it is of the class type. So we can pass it back as the value wanted. 
            return movement;
        }



    }







}