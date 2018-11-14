using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Calculadora.NUnit
{

    // Para esse exemplo, é necessário instalar o adapter NUnit3TestAdapter => Install-Package NUnit3TestAdapter
    [TestFixture]
    public class CalculadorasTests
    {
        #region SetUp para inicio dos testes
        private Util.Calculadora _calc;

        [SetUp]
        public void SetUp()
        {
            _calc = new Util.Calculadora();
        }
        #endregion

        #region Testes
        [Test]
        public void TesteSomar()
        {
            Assert.AreEqual(4, _calc.Somar(2, 2));
        }

        [Test]
        public void TesteSubtrair()
        {
            Assert.AreEqual(0, _calc.Subtrair(2, 2));
        }

        // Ignorando testes
        [Test]
        [Ignore("Descrição do porque ignorar este teste")]
        public void TesteSubtrairIgnorado()
        {
        }

        // Testando excessões
        [Test]
        public void TesteException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Util.Calculadora(2).Somar(1,1));
        }
        #endregion

        #region Liberando objetos e conexões ao fim dos testes
        [TearDown]
        public void TearDown()
        {
            _calc = null;
        }
        #endregion
    }
}
