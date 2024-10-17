namespace Dobrin_Catalina_lab2.Models
{
    public class Publishr
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
