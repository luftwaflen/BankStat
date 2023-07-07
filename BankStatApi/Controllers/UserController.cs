using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using BankStatApi.RequestModels;
using BankStatApi.ResponseModels;
using BankStatCore.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BankStatApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IAccountService _accountService;
    private readonly IMapper _mapper;

    public UserController(
        IUserService userService,
        IAccountService accountService,
        IMapper mapper
    )
    {
        _userService = userService;
        _accountService = accountService;
        _mapper = mapper;
    }

    [HttpPost]
    [Route("/user/register")]
    public ActionResult Register(UserRequest user)
    {
        var logginedUser = _userService.Register(user.Login, user.Password);
        if (logginedUser is null) throw new Exception("Registration error");
        return Ok();
    }

    [HttpPost]
    [Route("/user/login")]
    public ActionResult Login(UserRequest user)
    {
        var identity = GetIdentity(user.Login, user.Password);
        if (identity == null)
        {
            return BadRequest(new { errorText = "Invalid username or password." });
        }

        var now = DateTime.UtcNow;
        // создаем JWT-токен
        var jwt = new JwtSecurityToken(
            issuer: "ISSUER",
            audience: "AUDIENCE",
            notBefore: now,
            claims: identity.Claims,
            expires: now.Add(TimeSpan.FromMinutes(5)),
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes("!SomethingSecret!")),
                SecurityAlgorithms.HmacSha256));
        var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

        return Ok(encodedJwt);
    }

    private ClaimsIdentity GetIdentity(string login, string password)
    {
        var user = _userService.FindByLogin(login);
        if (!_userService.CheckPassword(login, password))
            throw new InvalidDataException("Invalid username or password");
        if (user != null)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login)
            };
            ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
            return claimsIdentity;
        }

        return null;
    }

    [HttpPut]
    [Route("/user/change_password")]
    [Authorize]
    public ActionResult ChangePassword(UserRequest userRequest, string newPassword)
    {
        var user = _userService.ChangePassword(userRequest.Login, userRequest.Password, newPassword);
        var res = _mapper.Map<UserResponse>(user);
        return Ok(res);
    }

    [HttpGet]
    [Route("/user/accounts")]
    [Authorize]
    public ActionResult<IEnumerable<AccountResponce>> Accounts()
    {
        var accountModels = _userService.GetAccounts(User.Identity.Name);
        var accounts = _mapper.Map<List<AccountResponce>>(accountModels);

        return Ok(accounts);
    }

    [HttpPost]
    [Route("/user/accounts")]
    [Authorize]
    public ActionResult CreateAccount(AccountRequest req)
    {
        var login = User.Identity.Name;
        _userService.CreateAccount(login, req.Name, req.Amount, req.CurIso);
        return Ok($"Account {req.Name} created");
    }

    [HttpDelete]
    [Route("/user/accounts")]
    [Authorize]
    public ActionResult DeleteAccount(string accountId)
    {
        var login = User.Identity.Name;
        _userService.DeleteAccount(login, accountId);
        return Ok($"Account {accountId} deleted");
    }
}