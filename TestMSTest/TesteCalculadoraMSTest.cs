using ER2;

namespace TestMSTest
{
    [TestClass]
    public class TesteCalculadoraMSTest
    {
        [TestMethod]
        public void TestSomarDoisNumeros()
        {
            //Arrange
            double pNum = 1;
            double sNum = 1;
            double tNum = 2;

            //Act
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert
            Assert.AreEqual(tNum,resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(1, 2, 2)]
        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double tNum)
        {
            //Act 
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert
            Assert.AreEqual(tNum, resultado);
        
        }
    }
}