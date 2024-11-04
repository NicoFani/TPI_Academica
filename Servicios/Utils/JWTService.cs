using Datos.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Utils {
    public class JWTService {
        private readonly static string _jwtSecret = Environment.GetEnvironmentVariable("JWT_SECRET") ?? "";
        public static string GenerateToken(Persona persona) {
            var tokenHandler = new JwtSecurityTokenHandler();
            var byteKey = Encoding.UTF8.GetBytes(_jwtSecret);
            var tokenDesc = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(new Claim[] {
                        new Claim("IdPersona", persona.IdPersona.ToString()),
                        new Claim("NombreUsuario", persona.NombreUsuario),
                        new Claim("TipoPersona", persona.TipoPersona)
                    }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(byteKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDesc);
            return tokenHandler.WriteToken(token);
        }

        public static IDictionary<string, string> DecodeToken(string token) {
            var handler = new JwtSecurityTokenHandler();
            var dictionary = new Dictionary<string, string> {
                { "valid", "false" }
            };
            if (handler.CanReadToken(token)) {
                var jwtToken = handler.ReadJwtToken(token);
                var claims = jwtToken.Claims;

                foreach (var claim in claims) {
                    dictionary[claim.Type] = claim.Value;
                }
                dictionary["valid"] = "true";
            }

            return dictionary;
        }
    }
}