namespace Dobrin_Catalina_lab2.Models
{
    public class Authors
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Navigation property for Books
        public ICollection<Book>? Books { get; set; }
    }
}
