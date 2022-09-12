using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class LoginDto : BaseDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}