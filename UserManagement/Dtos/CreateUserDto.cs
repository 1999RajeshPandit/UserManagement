using System.ComponentModel.DataAnnotations;

namespace UserManagement.Dtos
{
    public class CreateUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [EmailAddress]
        public string UserName {  get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(10)]
        public string Password { get; set; }

        public string City {  get; set; }

        public string CompanyName {  get; set; }
    }
}
