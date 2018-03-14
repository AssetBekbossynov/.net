namespace midterm.Models{
    public class Category{
        public int Id { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }

        public Category(){}
        public Category(int Id, string Description, double Cost){
            this.Id = Id;
            this.Description = Description;
            this.Cost = Cost;
        }
        
        public string DataToString(){
            return Id + ";" + Description + ";" + Cost;
        }
    }
}