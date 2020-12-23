using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParsRollcall.Site.Models
{
    public class UserLoginVwModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
