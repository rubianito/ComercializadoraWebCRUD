using Data;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;

namespace UnitTests.MockupData
{
    /// <summary>
    /// Gestion de categorias, no se permite eliminar categorias ya que estas son relacionadas en 
    /// los productos y de ser necesario se requiere realizacion por medio directo de base de datos
    /// </summary>
    public class CategoriesDatTest : ICategoriesDat
    {
        private readonly Categories category;
        private readonly List<Categories> categories;
        public CategoriesDatTest()
        {
            Random random = new Random();
            category = new Categories()
            {
                CategoryId = 1,
                CategoryName = random.Next(0, 1000) + "nombre prueba"
            };

            categories = new List<Categories>();
            for (var i = 0; i < 100; i++)
            {
                categories.Add(new Categories()
                {
                    CategoryId = i,
                    CategoryName = random.Next(0, 1000) + "nombre prueba"
                });
            }
        }

        /// <summary>
        /// Consulta una sola categoria de base de datos
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<Categories> SelectCategory(int categoryId)
        {
            GeneralRequest<Categories> generalRequest = new GeneralRequest<Categories>()
            {
                Error = false,
                Exception = string.Empty,
                Message = string.Empty,
                Result = category
            };
            return generalRequest;
        }

        /// <summary>
        /// Consulta todas las categorias
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Categories>> SelectCategories()
        {
            GeneralRequest<List<Categories>> generalRequest = new GeneralRequest<List<Categories>>()
            {
                Error = false,
                Exception = string.Empty,
                Message = string.Empty,
                Result = categories
            };
            return generalRequest;
        }

        /// <summary>
        /// Agrega categoaria a la base de datos
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> AddCategory(Categories category)
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>()
            {
                Error = false,
                Exception = string.Empty,
                Message = string.Empty,
                Result = true
            };
            return generalRequest;
        }

        /// <summary>
        /// Edicion de nombre de categoria en base de datos
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> EditCategory(Categories category)
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>()
            {
                Error = false,
                Exception = string.Empty,
                Message = string.Empty,
                Result = true
            };
            return generalRequest;
        }
    }
}
