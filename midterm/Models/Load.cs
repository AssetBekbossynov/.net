namespace midterm.Models{
    public class Load{
        public int Id { get; set; }
        public string Phone { get; set; }
        public int CategoryId { get; set; }

        public Load(){
        }
        public Load(int Id, string Phone, int CategoryId){
            this.Id = Id;
            this.Phone = Phone;
            this.CategoryId = CategoryId;
        }

        public string DataToString(){
            return Id + ";" + Phone + ";" + CategoryId;
        }

    }
}