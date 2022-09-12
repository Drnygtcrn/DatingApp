using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException(string message): base(message)
        {
            
        }
    }
}