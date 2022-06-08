using greed.Game.Objects;
using greed.Game.Services;

namespace Game{

    class Director{
        private int cellSize = 15;
        private string caption = "Greed";
        private int width = 640;
        private int height = 480;
        private int frameRate = 0;
        private bool debug = false;

        Random Random = new Random();
        private bool Playing = true;
        
        public Director(){
            KeyboardServices keyBoard = new KeyboardServices(cellSize);
            VideoService videoService = new VideoService(caption, width, height, cellSize, frameRate, debug);   
        }

        public void StartGame(){
            

            Player player = new Player();
            VideoService.OpenWindow();
            while(VideoService.IsWindowOpen()){

                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);

            }        
        }
        private void GetInputs(Cast cast){
            Actor robot = cast.GetFirstActor("robot");
            Point velocity = keyboardService.GetDirection();
            robot.SetVelocity(velocity);
        }
        private void DoUpdates(){
            Actor banner = cast.GetFirstActor("banner");
            Actor robot = cast.GetFirstActor("robot");
            List<Actor> artifacts = cast.GetActors("artifacts");

            banner.SetText("");
            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();
            robot.MoveNext(maxX, maxY);

            foreach (Actor actor in artifacts)
            {
                if (robot.GetPosition().Equals(actor.GetPosition()))
                {
                    Artifact artifact = (Artifact) actor;
                    string message = artifact.GetMessage();
                    banner.SetText(message);
                }
            } 

        }
        private void DoOutputs(){
            List<Actor> actors = cast.GetAllActors();
            VideoService.ClearBuffer();
            VideoService.DrawActors(actors);
            VideoService.FlushBuffer();
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