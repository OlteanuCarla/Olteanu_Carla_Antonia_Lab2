using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Olteanu_Carla_Antonia_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        [StringLength(150, MinimumLength = 3)]
        [Required(ErrorMessage = "Titlul este obligatoriu")]
        public string Title { get; set; }

        public int? AuthorID { get; set; } // cheie străină către Author
        public Author? Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public int? BorrowingID { get; set; }
        public Borrowing? Borrowing { get; set; }

        [Display(Name = "Book Categories")]
       
        public ICollection<BookCategory>? BookCategories { get; set; }

    }
}
