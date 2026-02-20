using System.ComponentModel.DataAnnotations;
using Eatsy1.Models;
using Eatsy1.Validators;


public class Customer
{
    public int Id { get; set; }
    public string UserId { get; set; }
    [Required(ErrorMessage = "Emri eshte i detyrueshem.")]
    [StringLength(50, ErrorMessage = "Emri duhet te ket te pakten 50 karaktere.")]
    [StartWithCapitalLetter(ErrorMessage = "Emri duhet te filloje me shkronje te madhe.")]
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    public ICollection<Order> Orders { get; set; }
}