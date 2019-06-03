namespace ShopWeb.Helpers
{
    using Microsoft.AspNetCore.Identity;
    using ShopWeb.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

    }
}
