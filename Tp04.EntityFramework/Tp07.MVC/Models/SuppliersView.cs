using System.ComponentModel.DataAnnotations;

namespace Tp07.MVC.Models
{
    public class SuppliersView
    {
        [Key]
        [Required(ErrorMessage = "*Required field *")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "* Required field *")]
        [StringLength(40,ErrorMessage = "* Max length allowed is 40 characters *")]
        public string CompanyName { get; set; }

        [StringLength(30, ErrorMessage = "* Max length allowed is 30 characters *")]
        public string ContactName { get; set; }

        [StringLength(24, ErrorMessage = "* Max length allowed is 24 characters *")]
        public string Phone { get; set; }
    }
}