using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Exceptions;
using Application.Common.Models;
using Application.Interfaces;
using Infra.Authentication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Infra.Services;

public class ApplicationUserServices : IApplicationUserServices
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly JwtSettings _jwtSettings;
    public ApplicationUserServices(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IOptions<JwtSettings> jwtSettings)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _jwtSettings = jwtSettings.Value;
    }

    public async Task RegisterUser(string username, string password)
    {
        var newUser = new ApplicationUser
        {
            UserName = username,
        };
        var result = await _userManager.CreateAsync(newUser, password);
        if (!result.Succeeded)
        {
            var messages = result.Errors.Aggregate("", (current, error) => current + (error.Description + "\n"));
            throw new UserCreationFailedException(messages);
        }
    }

    public async Task<string> Login(string username, string password)
    {
        var result = await _signInManager.PasswordSignInAsync(username, password, false, false);
        if (!result.Succeeded)
            throw new LoginFailedException();
        var user = await _userManager.FindByNameAsync(username);
        var token = GenerateToken(user);
        return token;
    }
    public async Task Logout()
    {
        await _signInManager.SignOutAsync();
    }

    private string GenerateToken(ApplicationUser user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_jwtSettings.SecretKey);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject =new ClaimsIdentity(new []
            {
                new Claim(JwtRegisteredClaimNames.NameId, user.Id),
                new Claim(JwtRegisteredClaimNames.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            }),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}