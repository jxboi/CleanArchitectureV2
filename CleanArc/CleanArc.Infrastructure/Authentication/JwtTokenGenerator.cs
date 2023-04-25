using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CleanArc.Application.Common.Interfaces.Authentication;
using Microsoft.IdentityModel.Tokens;

namespace CleanArc.Infrastructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    public string GenerateToken(Guid guid, string firstName, string lastName)
    {
        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, guid.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes("super-secret-key")), SecurityAlgorithms.HmacSha256
        );

        var securityToken = new JwtSecurityToken(
            issuer: "Story",
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(30),
            signingCredentials: signingCredentials
        );

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }
} 