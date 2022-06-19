using System.ComponentModel.DataAnnotations;

namespace Tp07.MVC.Models
{
    public class SuppliersView
    {
        [Key]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo obligatorio")]

        [StringLength(40,ErrorMessage ="El máximo de carácteres permitido es 40")]
        public string CompanyName { get; set; }

        [StringLength(30, ErrorMessage = "El máximo de carácteres permitido es 30")]
        public string ContactName { get; set; }
    }
}