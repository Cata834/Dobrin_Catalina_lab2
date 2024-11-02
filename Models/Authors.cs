using System.ComponentModel.DataAnnotations;

namespace Dobrin_Catalina_lab2.Models
{
    public class Authors
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        // Navigation property for Books
        public ICollection<Book>? Books { get; set; }
    }
}
