namespace BlazorGame.Models
{
    public class SquareModels
    {
        private bool isShow;

        public int Id { get; set; }
        public string Styles { get; set; }
        public bool IsShow { 
            get { return isShow; } 
            set { 
                isShow = value;
                if (isShow)
                {
                    Styles = "topo";
                }
                else {
                    Styles = "";
                }
            } 
        }
    }
}
