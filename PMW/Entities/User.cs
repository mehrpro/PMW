using System.ComponentModel.DataAnnotations;

namespace PMW.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]

        public string Password { get; set; }
        [Required]
        public bool IsActive { get; set; }

    }
}