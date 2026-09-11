using LojaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMVCTeste
{
    public class ClienteTests
    {
        [Fact]
        public void Cliente_Maioridade()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Teste",
                Email = "teste@gmail.com",
                Idade = 10,
                Ativo = true
            };
            //Act
            var resultado = cliente.Validacao();
            //Assert
            Assert.False(resultado);
        }
        
        [Fact]
        public void Cliente_Email_Invalido()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Teste",
                Email = "testegmail.com",
                Idade = 18,
                Ativo = true
            };
            //Act
            var resultado = cliente.Validacao();
            //Assert
            Assert.False(resultado);
        }
        
        [Fact]
        public void Cliente_Nome_NuloVazio()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = null,
                Email = "teste@gmail.com",
                Idade = 18,
                Ativo = true
            };
            //Act
            var resultado = cliente.Validacao();
            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void Cliente_SemEmail()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Teste",
                Email = "",
                Idade = 18,
                Ativo = true
            };
            //Act
            var resultado = cliente.Permissao() && cliente.Validacao();
            //Assert
            Assert.False(resultado);
        }


        [Fact]
        public void Cliente_Inativo()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Teste",
                Email = "teste@gmail.com",
                Idade = 18,
                Ativo = false
            };
            //Act
            var resultado = cliente.Permissao() && cliente.Validacao();
            //Assert
            Assert.False(resultado);
        }
        
        [Fact]
        public void Cliente_AtivoeMaior()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Teste",
                Email = "teste@gmail.com",
                Idade = 18,
                Ativo = true
            };
            //Act
            var resultado = cliente.Permissao() && cliente.Validacao();
            //Assert
            Assert.True(resultado);
        }
    }
}
