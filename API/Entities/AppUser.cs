using API.Extensions;
using Microsoft.AspNetCore.Identity;

namespace API.Entities;

public class AppUser : IdentityUser<int>
{
    public string DisplayName { get; set; } = null!;
    public ICollection<AppUserRole> UserRoles { get; set; } = [];

    public DateOnly DateOfBirth { get; set; }

    public required string KnownAs { get; set; }
    public DateTime Create { get; set; }
    public DateTime LastActive { get; set; }
    public required string Gender { get; set; }
    public string? Introduction { get; set; }
    public string? Interests { get; set; }
    public string? LookingFor { get; set; }
    public required string City { get; set; }

    public required string Country { get; set; }
    public List<Photo> Photos { get; set; } = [];
    // public List<UserLike> LikedByUsers { get; set; }=[];
    // public List<UserLike> LikedUsers { get; set; }=[];
    // public List<Message> MessagesSent { get; set; }=[];
    // public List<Message> MessagesRceived { get; set; }=[];

    public int GetAge()
    {
        return DateOfBirth.CalculateAge();
    }
}

