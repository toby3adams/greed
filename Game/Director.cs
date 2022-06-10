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
            ScoreKeeper score = new ScoreKeeper();
            cast.AddActor("ScoreKeeper", score);

            // create player actor and add to Cast List
            Player player = new Player(); // creates player
            cast.AddActor("Player", player); // adds player to the cast list
            video.OpenWindow();
            while(video.IsWindowOpen()){
                /*
                **************Doug - Im assuming this will be where we will need code for creating new gems and rocks, hoping to dream something up tonight.
                */
                GetInputs(player, keyBoard);
                DoUpdates(player, cast, video, score);
                DoOutputs(cast, video);

            }        
        }
        private void GetInputs(Actor player, KeyboardServices keyBoard){

            player.shiftLocation(keyBoard.PlayerDirection(), 0); // Doug - takes keyboard input for player X coordinate shift from KeyboardService

        }
        private void DoUpdates(Player player, Cast cast, VideoService video, ScoreKeeper score){

            List<Actor> actors = cast.GetAllActors();
            
            foreach (Actor actor in actors){
                if (actor.character != "#"){
                    actor.shiftLocation(0, actor.FallSpeed);
                }
                if (actor.location_y > 500){
                    cast.RemoveActor("Rock", actor);
                    cast.RemoveActor("Gem", actor);
                }
                else if (actor.location_y <= player.location_y + 8 && actor.location_y >= player.location_y -8 && actor.character != "#") {
                    if (actor.location_x <= player.location_x + 8 && actor.location_x >= player.location_x -8){

                            score.game_score += actor.value;
                            cast.RemoveActor("Rock", actor);
                            cast.RemoveActor("Gem", actor);

                            // Console.WriteLine(score.game_score);
                        }
                   
                    }
                }

            // Console.WriteLine(actors.Count()); // for testing purposes


                // determines the pace that rocks or gems spawn per game loop
            if (rock_number == 0 || rock_number == 1 || rock_number == 2){
                Rock rock = new Rock();
                cast.AddActor("Rock", rock);

                rock_number += 1;
            }
            else if (rock_number == 3){
                Gem gem = new Gem();
                cast.AddActor("Gem",gem);

                rock_number += 1;                
            }
            else if (rock_number == 4){
                rock_number += 1;
            }
            else{
                rock_number = 0;
            }

            score.update_score();
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