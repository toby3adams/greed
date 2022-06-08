using Raylib_cs;
using greed.Game.Objects;

namespace greed.Game.Services{

    public class VideoService
    {
        private int cellSize = 15;
        private string caption = "";
        private int width = 640;
        private int height = 480;
        private int frameRate = 0;
        private bool debug = false;


        public VideoService(string caption, int width, int height, int cellSize, int frameRate, 
                bool debug)
        {
            this.caption = caption;
            this.width = width;
            this.height = height;
            this.cellSize = cellSize;
            this.frameRate = frameRate;
            this.debug = debug;
        }


        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }


        public void ClearBuffer()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.BLACK);
            if (debug)
            {
                DrawGrid();
            }
        }

        /// <summary>
        /// Draws the given actor's text on the screen.
        /// </summary>
        /// <param name="actor">The actor to draw.</param>
        public void DrawActor(Actor actor)
        {
            string text = actor.getCharacter();
            int x = actor.getLocationX();
            int y = actor.getLocationY();
            // int fontSize = actor.GetFontSize();
            int color = actor.getColor();
            Raylib_cs.Color color_r = ToRaylibColor(color);
            Raylib.DrawText(text, x, y, 15, color_r);
        }

        /// <summary>
        /// Draws the given list of actors on the screen.
        /// </summary>
        /// <param name="actors">The list of actors to draw.</param>
        public void DrawActors(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActor(actor);
            }
        }
        
        /// <summary>
        /// Copies the buffer contents to the screen. This method should be called at the end of
        /// the game's output phase.
        /// </summary>
        public void FlushBuffer()
        {
            Raylib.EndDrawing();
        }

        /// <summary>
        /// Gets the grid's cell size.
        /// </summary>
        /// <returns>The cell size.</returns>
        public int GetCellSize()
        {
            return cellSize;
        }

        /// <summary>
        /// Gets the screen's height.
        /// </summary>
        /// <returns>The height (in pixels).</returns>
        public int GetHeight()
        {
            return height;
        }

        /// <summary>
        /// Gets the screen's width.
        /// </summary>
        /// <returns>The width (in pixels).</returns>
        public int GetWidth()
        {
            return width;
        }

        /// <summary>
        /// Whether or not the window is still open.
        /// </summary>
        /// <returns>True if the window is open; false if otherwise.</returns>
        public bool IsWindowOpen()
        {
            return !Raylib.WindowShouldClose();
        }

        /// <summary>
        /// Opens a new window with the provided title.
        /// </summary>
        public void OpenWindow()
        {
            Raylib.InitWindow(width, height, caption);
            Raylib.SetTargetFPS(frameRate);
        }

        /// <summary>
        /// Draws a grid on the screen.
        /// </summary>
        private void DrawGrid()
        {
            for (int x = 0; x < width; x += cellSize)
            {
                Raylib.DrawLine(x, 0, x, height, Raylib_cs.Color.GRAY);
            }
            for (int y = 0; y < height; y += cellSize)
            {
                Raylib.DrawLine(0, y, width, y, Raylib_cs.Color.GRAY);
            }
        }

        /// <summary>
        /// Converts the given color to it's Raylib equivalent.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>A Raylib color.</returns>
        private Raylib_cs.Color ToRaylibColor(int color)
        {
            if (color == 1){//white
                return new Raylib_cs.Color(255, 255, 255, 255);
            }
            if (color == 2){//gray
                return new Raylib_cs.Color(133, 133, 133, 255);
            }
            if (color == 3){//red
                return new Raylib_cs.Color(255, 0, 0, 255);
            }
            if (color == 4){//green
                return new Raylib_cs.Color(0, 255, 0, 255);
            }
            if (color == 5){//blue
                return new Raylib_cs.Color(0, 0, 255, 255);
            }
            if (color == 6){//purple
                return new Raylib_cs.Color(187, 0, 255, 255);
            }
            else{
                return new Raylib_cs.Color(255, 153, 0, 255);   
            }

        }
    }
}