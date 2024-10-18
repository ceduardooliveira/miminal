using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miminal.Dominio.Enuns;

namespace miminal.Dominio.ModelViews
{
    public record AdminsitradorModelView
    {
        public int Id { get; set; } = default;
        public string Email { get; set; } = default;
        public string Perfil { get; set; } = default;
        
    }
}