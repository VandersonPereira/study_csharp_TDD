using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Estudo.Calculadora.Util;

namespace Estudo.Calculadora.xUnit
{
    public class TestCalculadora : IDisposable
    {
        // Para esse exemplo, é necessário instalar o xUnit e o xUnit.runner.visualstudio

        #region SetUp para inicio dos testes (no caso do xUnit, se faz isso no construtor)
        private Util.Calculadora _calc;

        public TestCalculadora()
        {
            _calc = new Util.Calculadora(3);
        }
        #endregion

        #region Testes
        [Fact]
        public void TesteSomar()
        {
            Assert.Equal(8, _calc.Somar(4, 4));
        }

        [Fact]
        public void TesteSomarComLimite()
        {
            Assert.Equal(8, _calc.Somar(4, 4));
        }

        // Testando excessões
        [Fact]
        public void TesteSomarForaLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => 
            {
                _calc.Somar(2, 2);
            });
        }
        #endregion

        #region Liberando objetos e conexões ao fim dos testes (no xUnit, se faz isso alterando o método Dispose, implementando a interface IDisposable)
        public void Dispose()
        {
            _calc = null;
        }
        #endregion
    }
}
