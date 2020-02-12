using Model;
using NUnit.Framework;

namespace TestModel
{
    public class TestsProductA
    {
        [Test]
        public void TestTariffName()
        {
            ProductA product = new ProductA(0,0);
            Assert.AreEqual("basic electricity tariff", product.Name);
        }
        [Test]
        public void TestAnnualExpenses()
        {
            ProductA product = new ProductA(5, 0.22);
            Assert.AreEqual(830, product.AnnualExpenses(3500));
            Assert.AreEqual(1050, product.AnnualExpenses(4500));
            Assert.AreEqual(1380, product.AnnualExpenses(6000));
            Assert.AreEqual(60, product.AnnualExpenses(0));
        }
    }
}