using Domain;
using Domain.Models;
using Domain.Requests;
using System.Collections.Generic;

namespace Data
{
    public interface IProductsDat
    {
        /// <summary>
        /// Consulta un solo producto de base de datos
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<Products> SelectProduct(int productId);

        /// <summary>
        /// Consulta los productos por nombre
        /// </summary>
        /// <param name="findProductsByName"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<List<Products>> SelectProductsByProductName(FindProductsByName findProductsByName);

        /// <summary>
        /// Consulta los productos por descripcion
        /// </summary>
        /// <param name="findProductsByDescription"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<List<Products>> SelectProductsByProductDescription(FindProductsByDescription findProductsByDescription);

        /// <summary>
        /// Consulta los productos por categorias
        /// </summary>
        /// <param name="findProductsByCategory"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<List<Products>> SelectProductsByCategory(FindProductsByCategory findProductsByCategory);

        /// <summary>
        /// Consulta todos los productos
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<List<Products>> SelectProducts(FindAllProducts findAllProducts);

        /// <summary>
        /// Agrega producto a la base de datos
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<bool> AddProduct(Products product);

        /// <summary>
        /// Edicion de producto en base de datos
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<bool> EditProduct(Products product);

        /// <summary>
        /// Borrado de producto en base de datos
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<bool> DeleteProduct(int productId);
    }
}
