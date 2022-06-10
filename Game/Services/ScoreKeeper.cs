using greed.Game.Objects;
namespace greed.Game.Services{
    public class ScoreKeeper : Actor{

        public int game_score = 0;



        public ScoreKeeper(){
            this.character = "";
            this.FallSpeed = 0;
            this.color = 1;
            this.location_x = 0;
            this.location_y = 0;
        }

        public void update_score(){
            this.character = $"Score: {game_score}";
        }

    }
}

