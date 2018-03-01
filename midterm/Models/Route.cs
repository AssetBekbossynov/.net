namespace midterm{
    class Route{
        public int Id { get; set; }
        public string Path { get; set; }
        public double Cost {get; set; }

        public Route(){}
        public Route(int Id, string Path, double Cost){
            this.Id = Id;
            this.Path = Path;
            this.Cost = Cost;
        }

        public string DataToString(){
            return Id + ";" + Path + ";" + Cost;
        }
    }
}