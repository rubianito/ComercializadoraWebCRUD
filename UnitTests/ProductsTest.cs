using Business;
using Domain.Models;
using Domain.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.MockupData;

namespace UnitTests
{
    [TestClass]
    public class ProductsTest
    {
        private readonly ProductsBss productsBss;
        private readonly ProductsDatTest productsDatTest;

        public ProductsTest()
        {
            productsDatTest = new ProductsDatTest();
            productsBss = new ProductsBss(productsDatTest);
        }

        [TestMethod]
        public void SelectProducts()
        {
            var validation = productsBss.SelectProducts(new FindAllProducts()
            {
                DescriptionAscending = false,
                NameAscending = false,
                OrderByDescription = false,
                OrderByName = false
            });
            Assert.IsFalse(validation.Error);
        }

        [TestMethod]
        public void AddProduct()
        {
            var validation = productsBss.AddProduct(new Products());
            Assert.IsTrue(validation.Result);
        }

        [TestMethod]
        public void SelectProduct()
        {
            var validation = productsBss.SelectProduct(1);
            Assert.IsNotNull(validation.Result);
        }
    }
}
