using BlazorGame.Models;

namespace BlazorGame.Pages
{
    public partial class BlazorGameComponent
    {
        int score = 0;
        int life = 10;
        int hitPosition = 0;
        string mensaje = "";
        int velocidadJuego = 1000;
        bool gameRun = true;

        public List<SquareModels> Squares { get; set; } =  new List<SquareModels>();

        public BlazorGameComponent() {
            for (int i = 0; i < 9; i++) {
                Squares.Add(new SquareModels { Id = i });
            }
        }
    }
}
