using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miminal.Dominio.Entidades;
using miminal.DTOs;

namespace miminal.Dominio.Interfaces;
public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
    
}