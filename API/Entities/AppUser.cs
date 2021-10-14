using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string userName  { get; set; }
    }
}//protected prop can be accessed from this class and any class tha inharits it