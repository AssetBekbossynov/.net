namespace midterm.Models{
    public class Route{
        public int Id { get; set; }
        public string Path { get; set; }
        public int Duration { get; set; }
        public double Cost {get; set; }

        public Route(){}
        public Route(int Id, string Path, int Duration, double Cost){
            this.Id = Id;
            this.Path = Path;
            this.Duration = Duration;
            this.Cost = Cost;
        }

        public string DataToString(){
            return Id + ";" + Path + ";" + Duration + ";" + Cost;
        }
    }
}