using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ContactModel
{
   
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "PhoneNumber is required")]
    public string PhoneNumber { get; set; }
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Address is required")]
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    // This property is not mapped to the database, but can be used for input validation or display purposes.
    [NotMapped]
    [Required(ErrorMessage = "DOB is required")]
    public string DOB { get; set; }
}