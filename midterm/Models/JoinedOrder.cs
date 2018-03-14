namespace midterm.Models{
    public class JoinedOrder{
        
        public int Id { get; set; }
        public string Path { get; set; }
        public int LoadId { get; set; }
        public string Category { get; set; }
        public string Phone { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public int TotalCost { get; set; }


    }
}