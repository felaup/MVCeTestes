using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaMVC.Models;

namespace LojaMVCTeste
{
    public class ProdutoTeste
    {
        [Fact]
        public void ValorProduto_Maior_Zero()
        {
            //Arrange
            var produto = new Produto
            { 
                Nome = "Mouse",
                Preco = 0,
                Estoque = 50
            };
            //Act
            var resultado = produto.Validacao();
            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void Estoque_Negativo()
        {
            var produto = new Produto
            {
                Nome = "Fone",
                Preco = 50,
                Estoque = -1
            };

            var resultado = produto.Validacao();

            Assert.False(resultado);
        }

        [Fact]
        public void Nome_VazioNulo()
        {
            var produto = new Produto
            {
                Nome = null,
                Preco = 50,
                Estoque = 10
            };

            var resultado = produto.Validacao();

            Assert.False(resultado);
        }

        [Fact]
        public void VerificaProduto()
        {
            var produto = new Produto
            {
                Nome = string.Empty,
                Preco = -1,
                Estoque = 0
            };

            var resultado = produto.Validacao()
            ; Assert.False(resultado);

        }
    }
}
