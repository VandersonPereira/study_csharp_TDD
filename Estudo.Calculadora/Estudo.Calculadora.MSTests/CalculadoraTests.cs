using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Estudo.Calculadora.MSTests
{
    [TestClass]
    public class CalculadoraTests
    {
        #region Inicio dos testes
        Util.Calculadora _calc;

        // Esse decorador, é usado para preparar o ambiente para os testes. Poderia sera aberta a conexão com o banco aqui por exemplo.
        [TestInitialize]
        public void SetUp()
        {
            _calc = new Util.Calculadora();
        }
        #endregion

        #region Testes
        [TestMethod]
        public void TestSomar()
        {
            Assert.AreEqual(4, _calc.Somar(2, 2));
        }

        [TestMethod]
        public void TestSubtrair()
        {
            Assert.AreEqual(0, _calc.Subtrair(2, 2));
        }

        // Testes que esperam excessões.
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSomarComException()
        {
            Util.Calculadora calcWithException = new Util.Calculadora(2);
            calcWithException.Somar(1, 1);
        }

        // Testes que ainda não foram pensados, podem ser escritos e ignorados, assim eles não somem do radar.
        [TestMethod]
        [Ignore]
        public void QualquerMetodo()
        {
            
        }
        #endregion

        #region Fim de testes
        // Depois de todos os testes, pode-se limpar os objetos, ou realizar alguma tratativa final.
        [TestCleanup]
        public void CleanUp()
        {
            _calc = null;
        }
        #endregion
    }
}
