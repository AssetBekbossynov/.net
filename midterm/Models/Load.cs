namespace midterm{
    class Load{
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public Load(){
        }
        public Load(int Id, int CategoryId){
            this.Id = Id;
            this.CategoryId = CategoryId;
        }

        public string DataToString(){
            return Id + ";" + CategoryId;
        }

    }
}