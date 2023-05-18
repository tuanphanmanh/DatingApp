namespace API.DTOs
{
    public class LoginDto
    {
        public static string Username { get; internal set; }
        public char[] Password { get; internal set; }
    }
}