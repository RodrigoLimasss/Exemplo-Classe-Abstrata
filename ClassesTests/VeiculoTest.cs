using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesTests
{
    [TestClass]
    public class VeiculoTest
    {
        [TestMethod]
        public void Veiculo_DeveLigarCarro()
        {
            Veiculo carro = new Carro();
            carro.Ligar();
            
            Assert.IsTrue(carro.IsLigado());
        }

        [TestMethod]
        public void Veiculo_DeveDesligarCarro()
        {
            Veiculo carro = new Carro();
            carro.Desligar();

            Assert.IsFalse(carro.IsLigado());
        }

        [TestMethod]
        public void Veiculo_DeveTer4RodasCarro()
        {
            Veiculo carro = new Carro();
            var actual = carro.GetRodas();

            const int expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Veiculo_DeveVerificarUsoDoCinto()
        {
            Carro carro = new Carro();
            carro.Ligar();

            var actual = carro.UsandoCinto();

            const bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        //////////////////////////////////////////////////
        //Testes da Moto
        //////////////////////////////////////////////////

        [TestMethod]
        public void Veiculo_DeveLigarMoto()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void Veiculo_DeveDesligarMoto()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void Veiculo_DeveTer2RodasMoto()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void Veiculo_DeveVerificarUsoDoCapacete()
        {
            Moto moto = new Moto();

            var actualNaoUsando = moto.UsandoCapacete();
            const bool expectedNaoUsando = false;

            //Ainda não deve estar usando capacete, pois ainda não ligou a moto.
            Assert.AreEqual(expectedNaoUsando, actualNaoUsando);

            //Ligando a moto.
            moto.Ligar();
            //Capacete colocado.

            //Agora deve estar usando capacete.
            var actualUsando = moto.UsandoCapacete();
            const bool expectedUsando = true;

            Assert.AreEqual(expectedUsando, actualUsando);
        }
    }
}
