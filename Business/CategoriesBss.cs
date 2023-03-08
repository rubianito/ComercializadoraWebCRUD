using Data;
using Domain;
using Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Business
{
    public class CategoriesBss
    {
        private readonly ICategoriesDat _categoriesDat;

        public CategoriesBss()
        {
            _categoriesDat = new CategoriesDat();
        }

        /// <summary>
        /// Comunmente utilizado para pruebas unitarias por inyeccion de dependencias
        /// </summary>
        /// <param name="categoriesDat"></param>
        public CategoriesBss(ICategoriesDat categoriesDat)
        {
            _categoriesDat = categoriesDat;
        }
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
                generalRequest = _categoriesDat.SelectCategory(categoryId);
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
                generalRequest = _categoriesDat.SelectCategories();
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
            try
            {
                generalRequest = _categoriesDat.AddCategory(category);
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
        /// Edicion de nombre de categoria en base de datos
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> EditCategory(Categories category)
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            try
            {
                generalRequest = _categoriesDat.EditCategory(category);
            }
            catch (Exception e)
            {
                generalRequest.Exception = JsonConvert.SerializeObject(e);
                generalRequest.Message = e.Message;
                generalRequest.Error = true;
            }
            return generalRequest;
        }
    }
}
