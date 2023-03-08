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
        /// <param name="productName"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<List<Products>> SelectProductsByProductName(string productName);

        /// <summary>
        /// Consulta los productos por descripcion
        /// </summary>
        /// <param name="productDescription"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<List<Products>> SelectProductsByProductDescription(string productDescription);

        /// <summary>
        /// Consulta los productos por categorias
        /// </summary>
        /// <param name="catetoryId"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<List<Products>> SelectProductsByCategory(int catetoryId);

        /// <summary>
        /// Consulta todos los productos
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<List<Products>> SelectProducts();

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

        /// <summary>
        /// Borrado de todos los productos
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<bool> DeleteAllProducts();

        /// <summary>
        /// Agregado de 100000 productos
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        GeneralRequest<bool> AddMassiveProducts();
    }
}
