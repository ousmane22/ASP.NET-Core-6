namespace TaskManagement.Models
{
    public class Task
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
