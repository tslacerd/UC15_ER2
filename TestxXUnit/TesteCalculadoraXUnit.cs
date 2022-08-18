using ER2;

namespace TestxXUnit
{
    public class TesteCalculadoraXUnit
    {
        [Fact]
        public void TestSomarDoisNumeros()
        {
            //Arrange
            double pNum = 1;
            double sNum = 1;
            double tNum = 2;

            //Act
            var resultado = Calculadora.Somar(pNum, sNum);
            //Assert
            Assert.Equal(tNum, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, 2, 2)]

        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double tNum)
        {
            //Act
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert
            Assert.Equal(tNum, resultado);
        }
    }
}