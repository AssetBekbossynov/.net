namespace midterm.Models{
    public class Order{
        public int Id { get; set; }
        public int RouteId { get; set; }
        public int LoadId { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public int TotalCost { get; set; }

        public Order(){}

        public Order(int Id, int RouteId, int LoadId, string OrderDate, string DeliveryDate, int TotalCost){
            this.Id = Id;
            this.RouteId = RouteId;
            this.LoadId = LoadId;
            this.OrderDate = OrderDate;
            this.DeliveryDate = DeliveryDate;
            this.TotalCost = TotalCost;
        }

        public string DataToString(){
            return Id + ";" + RouteId + ";" + LoadId + ";" + OrderDate + ";" + DeliveryDate + ";" + TotalCost;
        }

    }
}