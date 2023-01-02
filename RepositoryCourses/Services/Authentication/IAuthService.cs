using Microsoft.AspNetCore.Identity;
using RepositoryCourses.Data_Access.DTOS.Authentications;
using RepositoryCourses.Domain.Models.Authentication;

namespace RepositoryCourses.Services.Authentication
{
    public interface IAuthService
    {
        string GenerateToken(IdentityUser identityUser);

        Task<AuthResults> Register(UserRegisterDTOS userRegisterDTOS);
        Task<AuthResults> Login(UserLoginDTO userLoginDTO);


    }
}
