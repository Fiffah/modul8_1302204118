namespace modul8_1302204118
{
    public class Movies
    {
        private string v1;
        private string v2;
        private List<string> stars2;
        private string v3;

        public Movies(string v1, string v2, List<string> stars2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.stars2 = stars2;
            this.v3 = v3;
        }

        private string Title { get; set; }
        private string Director { get; set; }
        private List<string> Stars { get; set; }
        private String Description { get; set; }
    }
}