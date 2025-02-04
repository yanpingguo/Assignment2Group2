using Assignment2Group2;

namespace Assignment2Group2UntTest
{
    public class Tests
    {
        public Product product { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            product = new Product(6,"Banana",7,2000);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(50000)]
        public void Test1(int prodId)
        {
            Assert.That(prodId, Is.GreaterThanOrEqualTo(5).And.LessThanOrEqualTo(50000));

        }

        [TestCase("Apple")]
        [TestCase(" Orange ")]
        [TestCase(" ")]
        public void Test2(string prodName)
        {
            Assert.That(prodName, Is.Not.Null.And.Not.Empty.And.Not.EqualTo(" ").And.Not.EqualTo("\t"));

        }

        [TestCase(50)]
        [TestCase(100.01)]
        [TestCase(5000)]
        public void Test3(double itemPrice)
        {
            Assert.That(itemPrice, Is.GreaterThanOrEqualTo(5).And.LessThanOrEqualTo(5000));
        }

        [TestCase(59)]
        [TestCase(40000)]
        [TestCase(500000)]
        public void Test4(int stockAmount)
        {
            Assert.That(stockAmount, Is.GreaterThanOrEqualTo(5).And.LessThanOrEqualTo(500000));

        }

        [TestCase(5)]
        [TestCase(4689)]
        [TestCase(49000)]
        public void Test5(int stockAmount)
        {
            product.IncreaseStock(stockAmount);
            Assert.That(product.StockAmount, Is.GreaterThanOrEqualTo(5).And.LessThanOrEqualTo(500000));
        }

        [TestCase(66)]
        [TestCase(899)]
        [TestCase(370)]
        public void Test6(int stockAmount)
        {
            product.DecreaseStock(stockAmount);
            Assert.That(product.StockAmount, Is.GreaterThanOrEqualTo(5).And.LessThanOrEqualTo(500000));
        }
    }
}