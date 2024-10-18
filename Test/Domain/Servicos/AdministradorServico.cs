using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using miminal.Dominio.Entidades;
using miminal.Infraestrutura.Db;

namespace Test.Domain.Entidades
{

    private DbContext CriarContextoDeTeste()
    {
        var options = new DbContextOptionsBuilder<DbContexto>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
        return new DbContexto(options);
    }


    public class AdministradorServicoTest
    {
        [TestMethod]
        public void TestandoSalvarAdministrador()
        {
            // Arrange
            var adm = new Administrador();
            adm.Id = 1;
            adm.Email = "teste@teste.com";
            adm.Senha = "teste";
            adm.Perfil = "Adm";

            // Act
            var context = new DbContext();

            // Assert
            Assert.AreEqual(1, adm.Id);
            Assert.AreEqual("teste@teste.com", adm.Email);
            Assert.AreEqual("teste", adm.Senha);
            Assert.AreEqual("Adm", adm.Perfil);
        }
    }
}