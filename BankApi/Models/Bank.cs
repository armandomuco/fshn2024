namespace BankApi.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Road { get; set; }
        public Boolean ATM { get; set; }
        public string Director { get; set; }
        public int NumberOfEmployers { get; set; }
    }

}
