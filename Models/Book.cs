using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CetBooks.Models
{
    public class Book
    {
        [DisplayName("Kitap No")]
        public int Id { get; set; }

        [DisplayName("Kitap Adı")]
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [DisplayName("Yazar")]
        [Required]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Publish Date")]
        [Required]
        public DateTime PublishDate { get; set; }

        [DisplayName("Page Size")]
        [Required]
        public int PageSize { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}

