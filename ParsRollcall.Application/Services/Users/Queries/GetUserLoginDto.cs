using System;
using System.Collections.Generic;
using System.Text;

namespace ParsRollcall.Application.Services.Users.Queries
{
    public class GetUserLoginDto
    {
        public Guid MyProperty { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
