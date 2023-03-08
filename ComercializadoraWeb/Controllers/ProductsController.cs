using Business;
using Domain.Models;
using Domain.Requests;
using System.Web.Mvc;

namespace ComercializadoraWeb.Controllers
{
    public class ProductsController : Controller
    {
        /// <summary>
        /// Obtiene un producto especifico
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public JsonResult SelectProduct([System.Web.Http.FromBody] int productId)
        {
            ProductsBss productsBss = new ProductsBss();
            return Json(productsBss.SelectProduct(productId), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Consulta los productos por nombre
        /// </summary>
        /// <param name="findByName"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        [HttpGet]
        [Route("[action]")]
        public JsonResult SelectProductsByProductName([System.Web.Http.FromBody] FindProductsByName findByName)
        {
            ProductsBss productsBss = new ProductsBss();
            return Json(productsBss.SelectProductsByProductName(findByName), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Consulta los productos por descripcion
        /// </summary>
        /// <param name="findByDescription"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        [HttpGet]
        [Route("[action]")]
        public JsonResult SelectProductsByProductDescription([System.Web.Http.FromBody] FindProductsByDescription findByDescription)
        {
            ProductsBss productsBss = new ProductsBss();
            return Json(productsBss.SelectProductsByProductDescription(findByDescription), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Consulta los productos por categorias
        /// </summary>
        /// <param name="findByCategory"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        [HttpGet]
        [Route("[action]")]
        public JsonResult SelectProductsByCategory([System.Web.Http.FromBody] FindProductsByCategory findByCategory)
        {
            ProductsBss productsBss = new ProductsBss();
            return Json(productsBss.SelectProductsByCategory(findByCategory), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Obtiene todos los productos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public JsonResult SelectProducts([System.Web.Http.FromBody] FindAllProducts findAllProducts)
        {
            ProductsBss productsBss = new ProductsBss();
            return Json(productsBss.SelectProducts(findAllProducts), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Inserta un producto
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public JsonResult AddProduct([System.Web.Http.FromBody] Products product)
        {
            ProductsBss productsBss = new ProductsBss();
            return Json(productsBss.AddProduct(product), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Edita un producto
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public JsonResult EditProduct([System.Web.Http.FromBody] Products product)
        {
            ProductsBss productsBss = new ProductsBss();
            return Json(productsBss.EditProduct(product), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Borrado de un producto
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public JsonResult DeleteProduct([System.Web.Http.FromBody] int productId)
        {
            ProductsBss productsBss = new ProductsBss();
            return Json(productsBss.DeleteProduct(productId), JsonRequestBehavior.AllowGet);
        }
    }
}
