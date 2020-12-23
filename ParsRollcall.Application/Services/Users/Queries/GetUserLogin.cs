using Microsoft.AspNetCore.Identity;
using ParsRollcall.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParsRollcall.Application.Services.Users.Queries
{
    public class GetUserLogin : IGetUserLoginService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public GetUserLogin(UserManager<User> userManager,SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task<bool> Execute(GetUserLoginDto loginDto)
        {
            User user=await userManager.FindByNameAsync(loginDto.UserName);
            if(user != null)
            {
                await signInManager.SignOutAsync();
                var result = await signInManager.PasswordSignInAsync(user, loginDto.Password, false, false);
                if (result.Succeeded)
                {
                    return true;
                }
                else
                { return false; }

            }
            else
            { return false; }
        }

    }
}
