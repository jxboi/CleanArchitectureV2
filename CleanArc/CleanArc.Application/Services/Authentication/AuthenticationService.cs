using CleanArc.Application.Common.Interfaces.Authentication;

namespace CleanArc.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "John", "Doe", email, "token");
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        //Check if email is already registered

        //Create user

        //Create the token 
        var token = _jwtTokenGenerator.GenerateToken(Guid.NewGuid(), firstName, lastName);

        return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, token);
    }
}