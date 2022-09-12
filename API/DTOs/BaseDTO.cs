using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;

namespace API.DTOs
{
    
    public class BaseDTO 
    {
        
        public bool IsSuccessful { get; set; }

        public string message { get; set; }
    }
}