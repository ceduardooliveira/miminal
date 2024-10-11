using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using miminal.Dominio.Entidades;
using miminal.DTOs;

namespace miminal.Dominio.Interfaces;
public interface IVeiculoServico
{
    List<Veiculo> Todos(int pagina = 1, string? nome=null, string? marca=null);
    Veiculo? BuscarPorId(int id);
    void Incluir(Veiculo veiculo);
    void Atualizar(Veiculo veiculo);

    void Apagar(Veiculo veiculo);
    
}