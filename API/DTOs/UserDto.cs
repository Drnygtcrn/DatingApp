using API.Data;

namespace API.DTOs
{
    public class UserDto : BaseDTO
    {
          
        public string Username { get; set; }
        public string Token { get; set; }
        public string PhotoUrl { get; set; }
        public string KnownAs { get; set; }
        public string Gender { get; set; }

        
    }
}