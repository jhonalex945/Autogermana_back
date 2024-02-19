using MediatR;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Seguridad.Api.Data;
using Seguridad.Api.Models;
using Seguridad.Api.Services.Response;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Seguridad.Services.EventHandlers
{
    public class UsuarioLoginEventHandler: IRequestHandler<UsuarioLoginCommand, ResponseLogin>
    {
        private readonly ApplicationDBContext _dBContext;
        private readonly IConfiguration _configuration;
        public UsuarioLoginEventHandler(ApplicationDBContext dBContext, IConfiguration configuration) 
        { 
            _dBContext = dBContext;
            _configuration = configuration;
        }

        public async Task<ResponseLogin> Handle(UsuarioLoginCommand usuarioLoginCommand, CancellationToken cancellationToken)
        {
            var result = new ResponseLogin();
            result.Success = false;
            result.Token = null;
            result.Message = "Acceso denegado, usuario o clave errada.";

            try
            {                
                var usuario = await _dBContext.Usuarios.FirstOrDefaultAsync(x => x.Email == usuarioLoginCommand.Usuario && x.Clave == usuarioLoginCommand.Password);

                if (usuario != null)
                {
                    result.Success = true;
                    await GenerateToken(usuario, result);
                    result.Message = "Ok";
                }
                return result;
            }
            catch (Exception ex)
            {                
                result.Message += ex.ToString();
                return result;
            }
            
        }     
        
        private async Task GenerateToken(Usuario usuario, ResponseLogin responseLogin)
        {            
            var secretkey = _configuration.GetValue<string>("SecretKey");
            var key = Encoding.ASCII.GetBytes(secretkey);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, usuario.UsuarioId.ToString()),
                new Claim(ClaimTypes.Email, usuario.Email),
                new Claim(ClaimTypes.Name, usuario.Nombre)                
            };

            var token = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var createToken =  tokenHandler.CreateToken(token);

            responseLogin.Token = tokenHandler.WriteToken(createToken);            
        }
    }
}
