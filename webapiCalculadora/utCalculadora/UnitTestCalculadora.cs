using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using webapiCalculadora.Controllers;
namespace utCalculadora
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestAddGet1()
        {
            //Arrange= preparacion 
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 7;

            //Act=ejecucion
            int result = calc.Add(numa, numb);

            //assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestAddGet2()
        {
            //Arrange= preparacion 
            CalculatorController calc = new CalculatorController();
            double numas = 0.3;
            double numbs = 0.4;
            double numress = 0.7;

            //Act=ejecucion
            double result = calc.Adddec(numas, numbs);

            //assert=verificacion
            Assert.AreEqual(numress, result);
        }
        [TestMethod]
        public void TestAdd3Get2()
        {
            //Arrange= preparacion 
            CalculatorController calc = new CalculatorController();
           int numa = -3;
            int numb = -4;
            int numc = -5;
            int numres = -12;

            //Act=ejecucion
            int result = calc.Add3(numa, numb,numc,numc);

            //assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultGet1()
        {
            //Arrange= preparacion 
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numc = 2;
            int numres = 24;

            //Act=ejecucion
            double result = calc.Mult3(numa, numb, numc);

            //assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMult3Get2()
        {
            //Arrange= preparacion 
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numc = -2;
            int numres = -24;

            //Act=ejecucion
            double result = calc.Mult3(numa, numb, numc);

            //assert=verificacion
            Assert.AreEqual(numres, result);
        }

    }
}
