namespace API;

public class UserDto{
    public required string Username { get; set;}
    public required string Token { get; set; }
    public string? KnownAs { get; set; }
    public string? Gender { get; set; }  
}