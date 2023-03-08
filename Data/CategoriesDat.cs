using Domain;
using Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    /// <summary>
    /// Gestion de categorias, no se permite eliminar categorias ya que estas son relacionadas en 
    /// los productos y de ser necesario se requiere realizacion por medio directo de base de datos
    /// </summary>
    public class CategoriesDat : ICategoriesDat
    {
        /// <summary>
        /// Consulta una sola categoria de base de datos
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<Categories> SelectCategory(int categoryId)
        {
            GeneralRequest<Categories> generalRequest = new GeneralRequest<Categories>();
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    generalRequest.Result = ctx.Categories.Where(x => x.CategoryId == categoryId).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                generalRequest.Exception = JsonConvert.SerializeObject(e);
                generalRequest.Message = e.Message;
                generalRequest.Error = true;
            }
            return generalRequest;
        }

        /// <summary>
        /// Consulta todas las categorias
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Categories>> SelectCategories()
        {
            GeneralRequest<List<Categories>> generalRequest = new GeneralRequest<List<Categories>>();
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    generalRequest.Result = ctx.Categories.Select(x => x).ToList();
                }
            }
            catch (Exception e)
            {
                generalRequest.Exception = JsonConvert.SerializeObject(e);
                generalRequest.Message = e.Message;
                generalRequest.Error = true;
            }
            return generalRequest;
        }

        /// <summary>
        /// Agrega categoaria a la base de datos
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> AddCategory(Categories category)
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            generalRequest.Result = true;
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    ctx.Categories.Add(category);
                    ctx.SaveChanges();
                }
            }
            catch (Exception e)
            {
                generalRequest.Exception = JsonConvert.SerializeObject(e);
                generalRequest.Message = e.Message;
                generalRequest.Error = true;
                generalRequest.Result = false;
            }
            return generalRequest;
        }

        /// <summary>
        /// Edicion de nombre de categoria en base de datos
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> EditCategory(Categories category)
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            generalRequest.Result = true;
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    var categoryToEdit = ctx.Categories.Where(x => x.CategoryId == category.CategoryId).FirstOrDefault();
                    categoryToEdit.CategoryName = category.CategoryName;
                    ctx.SaveChanges();
                }
            }
            catch (Exception e)
            {
                generalRequest.Exception = JsonConvert.SerializeObject(e);
                generalRequest.Message = e.Message;
                generalRequest.Error = true;
                generalRequest.Result = false;
            }
            return generalRequest;
        }
    }
}
