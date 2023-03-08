using Business;
using Domain.Models;
using System.Web.Mvc;

namespace ComercializadoraWeb.Controllers
{
    public class CategoriesController : Controller
    {
        /// <summary>
        /// Obtiene una categoria especifica
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public JsonResult SelectCategory([System.Web.Http.FromBody] int categoryId)
        {
            CategoriesBss categoriesBss = new CategoriesBss();
            return Json(categoriesBss.SelectCategory(categoryId), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Obtiene todas las categorias
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public JsonResult SelectCategories()
        {
            CategoriesBss categoriesBss = new CategoriesBss();
            return Json(categoriesBss.SelectCategories(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Inserta una categoria
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public JsonResult AddCategory([System.Web.Http.FromBody] Categories category)
        {
            CategoriesBss categoriesBss = new CategoriesBss();
            return Json(categoriesBss.AddCategory(category), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Edita una categoria
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public JsonResult EditCategory([System.Web.Http.FromBody] Categories category)
        {
            CategoriesBss categoriesBss = new CategoriesBss();
            return Json(categoriesBss.EditCategory(category), JsonRequestBehavior.AllowGet);
        }
    }
}
