using calculos;
using NUnit.Framework;

namespace Tests
{
    [TestFixture] // Indica que a classe contém testes unitários
    public class CalculadoraTest
    {
        private Calculadora _calculadora;

        public CalculadoraTest()
        {
            _calculadora = new Calculadora();
        }

        [Test] // Indica que é um método de teste
        public void Soma_DeveRetornarOValorCorreto()
        {
            // Declara os valores iniciais
            int valorInicial1 = 10;
            int valorInicial2 = 20;

            // Soma os valores
            var resultado = _calculadora.Soma(valorInicial1, valorInicial2);

            // Verifica se o resultado é igual a soma dos dois valores
            Assert.That((valorInicial1 + valorInicial2), Is.EqualTo(resultado));
        }

        [Test]
        public void RestoDivisao_DeveRetornarOValorCorreto()
        {
            // Efetua a divisão e desconstroi o resultado
            var (quociente, resto) = _calculadora.RestoDivisao(10, 3);

            // Agrupa os comparadores
            Assert.Multiple(() =>
            {
                //Verifica se o quociente da divisão é 3
                Assert.That(3, Is.EqualTo(quociente));

                //Verifica se o resto da divisão é 1
                Assert.That(1, Is.EqualTo(resto));
            });
        }

        [TestCase(1)] // Teste em cascata
        [TestCase(2)]
        [TestCase(3)]
        public void RestoDivisao_DeveRetornarZero(int value)
        {
            var resultado = _calculadora.RestoDivisao(12, value);

            //Verifica se o resto da divisão é 0
            Assert.That(0, Is.EqualTo(resultado.resto));
        }

        [Test]
        public void Subtracao_DeveRetornarOValorCorreto()
        {
            var resultado = _calculadora.Subtracao(20, 10);

            //Verifica se o resultado é igual a 10
            Assert.That(10, Is.EqualTo(resultado));
        }

        [Test]
        public void Divisao_DeveRetornarOValorCorreto()
        {
            var resultado = _calculadora.Divisao(100, 10);

            //Verifica se o resultado é igual a 10
            Assert.That(10, Is.EqualTo(resultado));
        }

        [Test]
        public void Multiplicacao_DeveRetornarOValorCorreto()
        {
            var resultado = _calculadora.Multiplicacao(5, 2);

            //Verifica se o resultado é igual a 10
            Assert.That(10, Is.EqualTo(resultado));
        }
    }
}