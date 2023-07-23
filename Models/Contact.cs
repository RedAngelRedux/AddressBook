using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Models
{
    public class Contact
    {
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string Address1 { get; set; } = string.Empty;

        public string? Address2 { get; set; }

        [Required]
        public string City { get; set; } = string.Empty;

        [Required]
        public string State { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.PostalCode)]
        public int Zip { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        [NotMapped]
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }

        public byte[]? ImageData { get; set; }

        public string? ImageType { get; set; }

        [Key]
        public int Id { get; set; }
        
        [NotMapped]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
