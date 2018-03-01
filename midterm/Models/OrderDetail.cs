namespace midterm{
    class OrderDetail{
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Status { get; set; }

        public OrderDetail(){}
        public OrderDetail(int Id, int OrderId, string Status){
            this.Id = Id;
            this.OrderId = OrderId;
            this.Status = Status;
        }

        public string DataToString(){
            return Id + ";" + OrderId + ";" + Status;
        }
    }
}