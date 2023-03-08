using Domain;
using Domain.Models;
using System.Collections.Generic;

namespace Data
{
    public interface ICategoriesDat
    {
        /// <summary>
        /// Consulta una sola categoria de base de datos
        /// </summary>
        /// <param name="catogoryId"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<Categories> SelectCategory(int catogoryId);

        /// <summary>
        /// Consulta todas las categorias
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<List<Categories>> SelectCategories();

        /// <summary>
        /// Agrega categoaria a la base de datos
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<bool> AddCategory(Categories category);

        /// <summary>
        /// Edicion de nombre de categoria en base de datos
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<bool> EditCategory(Categories category);
    }
}
