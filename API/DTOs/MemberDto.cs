namespace API.DTOs;
public class MemberDto
{
    public string DisplayName { get; set; } = null!;

    public int Age { get; set; }

    public string? KnownAs { get; set; }
    public DateTime Create { get; set; }
    public DateTime LastActive { get; set; }
    public string? Gender { get; set; }
    public string? Introduction { get; set; }
    public string? Interests { get; set; }
    public string? LookingFor { get; set; }
    public string? City { get; set; }

    public string? Country { get; set; }
    public List<PhotoDto>? Photos { get; set; }=[];
    // public List<UserLike> LikedByUsers { get; set; }=[];
    // public List<UserLike> LikedUsers { get; set; }=[];
    // public List<Message> MessagesSent { get; set; }=[];
    // public List<Message> MessagesRceived { get; set; }=[];

}

