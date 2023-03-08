using Business;
using Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.MockupData;

namespace UnitTests
{
    [TestClass]
    public class CategoriesTest
    {
        private readonly CategoriesBss categoriesBss;
        private readonly CategoriesDatTest categoriesDatTest;

        public CategoriesTest()
        {
            categoriesDatTest = new CategoriesDatTest();
            categoriesBss = new CategoriesBss(categoriesDatTest);
        }

        [TestMethod]
        public void SelectCategories()
        {
            var validation = categoriesBss.SelectCategories();
            Assert.IsFalse(validation.Error);
        }

        [TestMethod]
        public void AddCategory()
        {
            var validation = categoriesBss.AddCategory(new Categories());
            Assert.IsTrue(validation.Result);
        }

        [TestMethod]
        public void SelectCategory()
        {
            var validation = categoriesBss.SelectCategory(1);
            Assert.IsNotNull(validation.Result);
        }
    }
}
