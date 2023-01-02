using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using RepositoryCourses.Data_Access.DTOS.Authentications;
using RepositoryCourses.Domain.Models.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RepositoryCourses.Services.Authentication
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        public AuthService(IConfiguration configuration, UserManager<IdentityUser> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }

        public async Task<AuthResults> Register(UserRegisterDTOS userRegisterDTOS)
        {
            var user_exist = await _userManager.FindByEmailAsync(userRegisterDTOS.Email);
            if (user_exist != null)
            {

                return
                new AuthResults()
                {
                    Result = false,
                    Errors = new List<string>()
                     {
                          "Email already exists"
                     }
                };
            }

            var new_user = new IdentityUser()
            {
                Email = userRegisterDTOS.Email,
                UserName = userRegisterDTOS.Email,
            };
            var create_user = await _userManager.CreateAsync(new_user, userRegisterDTOS.Password);

            if (create_user.Succeeded)
            {
                //generate token 
                var token = GenerateToken(new_user);
                return new AuthResults()
                {
                    Result = true,
                    token = token
                };
            }
            return new AuthResults()
            {
                Result = false,
                Errors = new List<string>()
                {
                    "Server Error"
                }
            };
        }

        public async Task<AuthResults> Login(UserLoginDTO userLoginDTO)
        {
            //find user
            var user_exist = await _userManager.FindByEmailAsync(userLoginDTO.Email);
            if (user_exist == null)
            {
                return
                new AuthResults()
                {
                    Result = false,
                    Errors = new List<string>()
                     {
                          "invalid payload"
                     }
                };
            }

            //check password

            var isCorrectPassword = await _userManager.CheckPasswordAsync(user_exist, userLoginDTO.Password);
            if (!isCorrectPassword)
            {
                return new AuthResults()
                {
                    Errors = new List<string>() { "invalid Password" },
                    Result = false
                };
            }
            var token = GenerateToken(user_exist);
            return new AuthResults() { Result = true, token = token };
        }

        public string GenerateToken(IdentityUser identityUser)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("JwtConfigurations:Secret").Value);
            //token descriptor
            var descriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[]
                {
                     new Claim("Id",identityUser.Id),
                     new Claim(JwtRegisteredClaimNames.Sub,identityUser.Email),
                     new Claim(JwtRegisteredClaimNames.Email,identityUser.Email),
                     new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                     new Claim(JwtRegisteredClaimNames.Iat,DateTime.Now.ToUniversalTime().ToString())
                 }),

                Expires = DateTime.Now.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256),

            };

            var token = jwtTokenHandler.CreateToken(descriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);
            return jwtToken;
        }


    }
}
