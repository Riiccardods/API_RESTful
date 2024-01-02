using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Cadastro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}
