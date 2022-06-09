using greed.Game.Objects;
using greed.Game.Services;
/*
Doug Notes 6/8 2134hrs
    worked through code line by line, matching existing code from the Articulate with the code we have written in our classes.
    played with the code until there were no red squigglies. At this juncture I have no idea what will work and what wont.
*/
namespace greed.Game{

    class Director{
        
        //private KeyboardServices keyBoard = null;   // parroting Articulate, dont think we need this code necessarily
        //private VideoService video = null;
        //private Cast cast = null;

        Random Random = new Random();
        private bool Playing = true;
        private int cellSize = 15;
            private string caption = "Greed";
            private int width = 640;
            private int height = 480;
            private int frameRate = 15;
            private bool debug = false;
            private int rock_number = 0;
        public Director(){            
        }

        public void StartGame(){
            KeyboardServices keyBoard = new KeyboardServices(cellSize);
            VideoService video = new VideoService(caption, width, height, cellSize, frameRate, debug);  
            Cast cast = new Cast();

            // create player actor and add to Cast List
            Player player = new Player(); // creates player
            cast.AddActor("Player", player); // adds player to the cast list
            video.OpenWindow();
            while(video.IsWindowOpen()){
                /*
                **************Doug - Im assuming this will be where we will need code for creating new gems and rocks, hoping to dream something up tonight.
                */
                GetInputs(player, keyBoard);
                DoUpdates(cast, video);
                DoOutputs(cast, video);

            }        
        }
        private void GetInputs(Actor player, KeyboardServices keyBoard){

            player.shiftLocation(keyBoard.PlayerDirection(), 0); // Doug - takes keyboard input for player X coordinate shift from KeyboardService

        }
        private void DoUpdates(Cast cast, VideoService video){

            // Actor player = cast.GetFirstActor("player");
            // List<Actor> Rocks_Gems = cast.GetActors("artifacts"); 

            List<Actor> actors = cast.GetAllActors();
            
            foreach (Actor actor in actors){
                if (actor.character != "#"){
                    actor.shiftLocation(0, 10);
                }
                if (actor.location_y > 500){
                    cast.RemoveActor("Rock", actor);
                    cast.RemoveActor("Gem", actor);
                }
            }

            // Console.WriteLine(actors.Count()); // for testing purposes

            Rock rock = new Rock();
            cast.AddActor("Rock", rock);



            //banner.SetText(""); //Doug - used in Robot finds kitten, not sure what to replace with,if at all

            // foreach (Actor actor in Rocks_Gems)
            // {
            //     if (player.getLocationX().Equals(actor.getLocationX()))
            //     {
            //         if(actor == "rock") // Doug - red and squigly, hoping to use this logic to do something magical when the player collides with a gem
            //         {
            //             Rock rock = (Rock) actor; // Doug - not sure if this is correct, but it's not red and squigly, so thats a plus
            //         } else if (actor == "gem") // Doug - red and squigly, hoping to use this logic to do something magical when the player collides with a gem
            //         {
            //             Gem gem = (Gem) actor; // Doug - not sure if this is correct, but it's not red and squigly, so thats a plus
            //         }
                    //Artifact artifact = (Artifact) actor;
                    //string message = artifact.GetMessage();
                   //banner.SetText(message);
                // }
            // } 

        }
        private void DoOutputs(Cast cast, VideoService video){
            List<Actor> actors = cast.GetAllActors();
            video.ClearBuffer();
            video.DrawActors(actors);
            video.FlushBuffer();
        }
        
        private void CreateRock(){
            Rock rock = new Rock();

        }
        private void CreateGem(){
            Gem gem = new Gem();

        }
        private void init(){
            
        }
    }
}