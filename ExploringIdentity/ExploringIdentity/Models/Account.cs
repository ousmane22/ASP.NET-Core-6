namespace ExploringIdentity.Models
{
    public class Account
    {
        public int ID { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
