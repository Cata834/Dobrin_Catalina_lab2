using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Dobrin_Catalina_lab2.Models
{
    public class Book
    { 
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        public string Title { get; set; }
        
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publishr? Publisher { get; set; }

        public int? AuthorID { get; set; } // Foreign Key
        public Authors? Author { get; set; } // Navigation property către Authors
    } 

}

