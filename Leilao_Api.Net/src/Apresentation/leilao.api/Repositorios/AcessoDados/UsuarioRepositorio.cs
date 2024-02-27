﻿using leilao.api.Entities;
using leilao.api.Interfaces;
using System.IdentityModel.Tokens.Jwt;

namespace leilao.api.Repositorios.AcessoDados
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly LeilaoDbContext _leilaoDbContext;

        public UsuarioRepositorio(LeilaoDbContext leilaoDbContext) => _leilaoDbContext = leilaoDbContext;

        public string? TokenOnRequest(HttpContext context)
        {
            var authenticationHeader = context.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(authenticationHeader))
            {
                return null;
            }

            var authenticationHeaderValue = authenticationHeader.ToString();

            if (!authenticationHeaderValue.StartsWith("Bearer "))
            {
                return null;
            }

            return authenticationHeaderValue["Bearer ".Length..];
        }

        public int DecodeJwtToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

            if (jsonToken == null)
            {
                throw new ArgumentException("Token inválido");
            }


            var id = jsonToken.Claims.FirstOrDefault(claim => claim.Type == "id")?.Value;


            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("ID não encontrado no token");
            }

            return Convert.ToInt32(id);
        }

        public UsuarioModel? BuscarUser(int tokenId)
        {
            try
            {
                var result = _leilaoDbContext
                    .Users.FirstOrDefault(user => user.Id == Convert.ToInt32(tokenId));
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
