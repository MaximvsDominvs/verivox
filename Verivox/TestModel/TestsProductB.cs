using Model;
using NUnit.Framework;

namespace TestModel
{
    public class TestsProductB
    {
        [Test]
        public void TestTariffName()
        {
            ProductB product = new ProductB(800, 4000, 0.3);
            Assert.AreEqual("Packaged tariff", product.Name);
        }
        [Test]
        public void TestAnnualExpenses()
        {
            ProductB product = new ProductB(800, 4000, 0.3);
            Assert.AreEqual(800, product.AnnualExpenses(3500));
            Assert.AreEqual(950, product.AnnualExpenses(4500));
            Assert.AreEqual(1400, product.AnnualExpenses(6000));
            Assert.AreEqual(800, product.AnnualExpenses(0));
        }
    }
}
