using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsRollcall.Application.Services.Users.Queries
{
    public interface IGetUserLoginService
    {
          Task<bool>  Execute(GetUserLoginDto loginDto);
    }
}
