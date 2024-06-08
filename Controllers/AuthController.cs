using job_board.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using job_board.utils;
using Microsoft.EntityFrameworkCore;

namespace job_board.Controllers
{
    public class UserDto
    {
        public required string username { get; set; }
        public required string password { get; set; }


        public int IdRol {  get; set; }
        public int companyId { get; set; }
        public int aspiranteId { get; set; }

    }

    public class ValidateUserDto
    {
        public required string username { get; set; }
    }

    public class ValidUserReturn
    {
        public Boolean existUser { get; set; }
    }


    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SupertexDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(SupertexDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<ActionResult<Usuario>> Register(UserDto request)
        {
            string password = BCrypt.Net.BCrypt.HashPassword(request.password);
            Usuario user = new Usuario();
            user.Username = request.username;
            user.Password = password;

            user.IdRol = request.IdRol;
            if (request.companyId != 0)
            {
                user.IdEmpresa = request.companyId;
            }
            if (request.aspiranteId != 0)
            {
                user.IdAspirante = request.aspiranteId;
            }
            try
            {
                _context.Usuarios.Add(user);
                await _context.SaveChangesAsync();

                return Created("uri", user);
            }
            catch (DbUpdateException ex) when (ex.InnerException.Message.Contains("IX_Usuario_Username"))
            {
                return Conflict(new ErrorResponse("El Username ya está en uso.", StatusCodes.Status409Conflict, ex.InnerException.Message));
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, new ErrorResponse("Error inesperado al guardar.", 500, ex.InnerException.Message));

            }
        }

        [HttpPost("login")]
        public ActionResult<string> Login(UserDto request)
        {
            String accessToken;
            Usuario user = _context.Usuarios.FirstOrDefault(u => u.Username == request.username);

            if (user == null)
            {
                return BadRequest(new ErrorResponse("Usuario no encontrado", StatusCodes.Status404NotFound, ""));
            }

            if (!BCrypt.Net.BCrypt.Verify(request.password, user.Password))
            {
                return Unauthorized(new ErrorResponse("Usuario o contraseña incorrectas", StatusCodes.Status401Unauthorized, ""));
            }
            accessToken = CreateToken(user);

            return Ok(new
            {
                status = "success",
                message = "Authentication successful",
                token = accessToken
            });
        }

        [HttpPost("valid-user")]
        public ActionResult<ValidUserReturn> validUser(ValidateUserDto request)
        {
            Usuario user = _context.Usuarios.FirstOrDefault(u => u.Username == request.username);
            ValidUserReturn validUserReturn = new ValidUserReturn();
            validUserReturn.existUser = user != null;

            return Ok(validUserReturn);
        }


        private string CreateToken(Usuario user)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim("username", user.Username));
            if (user.IdRol != null)
                claims.Add(new Claim("IdRol", user.IdRol.ToString()));

            if (user.IdRolNavigation != null)
                claims.Add(new Claim("RolName", user.IdRolNavigation.Nombre));

            if (user.IdEmpresa != null)
                claims.Add(new Claim("IdEmpresa", user.IdEmpresa.ToString()));

            if (user.IdAspirante != null)
                claims.Add(new Claim("IdAspirante", user.IdAspirante.ToString()));


            string key = _configuration.GetSection("jwtSetting:token").Value;

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var cred = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: cred
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }

    }
}
