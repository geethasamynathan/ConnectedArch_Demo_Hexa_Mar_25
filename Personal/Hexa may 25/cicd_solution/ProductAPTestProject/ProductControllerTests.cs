using Microsoft.AspNetCore.Mvc;
using ProductAPIDemo.Controllers;
using ProductAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAPIDemo.Controllers;
using ProductAPIDemo.Models;

namespace ProductAPTestProject
{
    public class ProductControllerTests
    {
        [Test]
        public void Get_ReturnsListOfProducts()
        {
            // Arrange
            var controller = new ProductsController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);

            var okResult = result.Result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.IsInstanceOf<List<Product>>(okResult.Value);

            var products = okResult.Value as List<Product>;
            Assert.AreEqual(3, products.Count);

            Assert.AreEqual("Keyboard", products[0].Name);
            Assert.AreEqual(49.99m, products[0].Price);

            Assert.AreEqual("Mouse", products[1].Name);
            Assert.AreEqual("Headset", products[2].Name);
        }
    }
}
