
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using studManagementAPI.Services;
using studManagementAPI.Data;
using studManagementAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace studManagementAPI.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }


        [HttpPost("login")]
        public IActionResult Login(LoginDTO request)
        {

            var user = _context.Users
          .FirstOrDefault(x => x.Username == request.Username
                            && x.Password == request.Password);

            if (user == null)
                return Unauthorized();

            var token = _tokenService.GenerateToken(user.Username);

            return Ok(new { Token = token });
        }
    }
}
