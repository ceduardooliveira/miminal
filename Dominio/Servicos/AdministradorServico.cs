using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miminal.Dominio.Entidades;
using miminal.Dominio.Interfaces;
using miminal.DTOs;
using miminal.Infraestrutura.Db;

namespace miminal.Dominio.Servicos
{
    public class AdministradorServico : IAdministradorServico
    {

        private readonly DbContexto _contexto;

        public AdministradorServico(DbContexto contexto)
        {
            _contexto = contexto;
        }
        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
            return adm;     
        
        }
    }
}