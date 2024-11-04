using NewTalents;

namespace TestNewTalents
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora  calc = new Calculadora();

            int resultadoCalculadora = calc.Somar(val1, val2);

            //Assert

            Assert.Equal(resultado, resultadoCalculadora);
        }


        [Fact]
        public void TesteMultiplicar()
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.Somar(4, 5);

            //Assert

            Assert.Equal(20, resultado);
        }

        [Fact]
        public void TestarDivisãoPorZero()
        {
            Calculadora calc = new Calculadora();

            //Assert
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3,1)

            );                  
           
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(4, 5);
            calc.Somar(6,7);

            var lista = calc.historico();
            //Assert
            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count());

        }
    }
}