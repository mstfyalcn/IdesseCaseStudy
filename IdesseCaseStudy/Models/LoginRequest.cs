namespace IdesseCaseStudy.Models;
public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string VerificationCode { get; set; } = "";
}