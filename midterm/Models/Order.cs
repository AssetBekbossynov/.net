namespace midterm{
    class Order{
        public int Id { get; set; }
        public int RouteId { get; set; }
        public int LoadId { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public int TotalCost { get; set; }
    }
}