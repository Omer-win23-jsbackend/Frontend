using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Frontend.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string Firstname { get; set; } = null!;
    public string Lastname { get; set; } = null!;
    public string? ProfileImage { get; set; } = "avatar.jpg";
    public string? Bio { get; set; }
    public int? AddressId { get; set; }
    public AdressEntity? Address { get; set; }

}
public class AdressEntity
{
    [Key]
    public int Id { get; set; }
    public string AddressLine_1 { get; set; } = null!;
    public string? AddressLine_2 { get; set; }
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

}