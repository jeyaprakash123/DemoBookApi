using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookDetails.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFirstName { get; set; }
        public decimal Price { get; set; }

        [NotMapped]
        public string MLA => $"{AuthorLastName},{AuthorFirstName}.\"{Title}.\" {Publisher},{DateTime.Now.Year}.";

        [NotMapped]
        public string Chicago => $"{AuthorLastName},{AuthorFirstName}.{Title}.{Publisher},{DateTime.Now.Year}.";
    }
}
