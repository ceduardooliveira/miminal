using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; // Adicione esta linha se não estiver presente
using miminal.Dominio.Entidades;

namespace miminal.Infraestrutura.Db
{
    public class DbContexto : DbContext
    {
        private readonly IConfiguration _configuracaoAppSettings;

        // Corrigido: nome do construtor deve ser o mesmo que o da classe
        public DbContexto(IConfiguration configuracaoAppSettings) // Alterado de DbContext para DbContexto
        {
            _configuracaoAppSettings = configuracaoAppSettings;
        }

        public DbSet<Administrador> Administradores { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var stringConexao = _configuracaoAppSettings.GetConnectionString("mysql")?.ToString();
                if (!string.IsNullOrEmpty(stringConexao))
                {
                    optionsBuilder.UseMySql(
                        stringConexao,
                        ServerVersion.AutoDetect(stringConexao)
                    );
                }
            }
        }
    }
}
