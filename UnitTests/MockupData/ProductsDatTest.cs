using Data;
using Domain;
using Domain.Models;
using Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests.MockupData
{
    /// <summary>
    /// Gestion de productos en base de datos
    /// </summary>
    public class ProductsDatTest : IProductsDat
    {
        private readonly Products product;
        private readonly List<Products> products;
        public ProductsDatTest()
        {
            Random random = new Random();
            product = new Products()
            {
                CategoryId = 1,
                ProductDescription = random.Next(0, 1000) + "Descripcion de producto prueba",
                ProductId = 1,
                ProductImage = random.Next(0, 1000) + "prueba.jpg",
                ProductName = random.Next(0, 1000) + "nombre prueba"
            };

            products = new List<Products>();
            for (var i = 0; i < 100; i++)
            {
                products.Add(new Products()
                {
                    CategoryId = 1,
                    ProductDescription = random.Next(0, 1000) + "Descripcion de producto prueba",
                    ProductId = i,
                    ProductImage = random.Next(0, 1000) + "prueba.jpg",
                    ProductName = random.Next(0, 1000) + "nombre prueba"
                });
            }
        }

        /// <summary>
        /// Consulta un solo producto de base de datos
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<Products> SelectProduct(int productId)
        {
            product.ProductId = productId;
            GeneralRequest<Products> generalRequest = new GeneralRequest<Products>()
            {
                Error = false,
                Exception = string.Empty,
                Message = string.Empty,
                Result = product
            };
            return generalRequest;
        }

        /// <summary>
        /// Consulta los productos por nombre
        /// </summary>
        /// <param name="productName"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProductsByProductName(string productName)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>()
            {
                Error = false,
                Exception = string.Empty,
                Message = string.Empty,
                Result = products
            };
            return generalRequest;
        }

        /// <summary>
        /// Consulta los productos por descripcion
        /// </summary>
        /// <param name="productDescription"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProductsByProductDescription(string productDescription)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>()
            {
                Error = false,
                Exception = string.Empty,
                Message = string.Empty,
                Result = products
            };
            return generalRequest;
        }

        /// <summary>
        /// Consulta los productos por categorias
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProductsByCategory(int categoryId)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>()
            {
                Error = false,
                Exception = string.Empty,
                Message = string.Empty,
                Result = products
            };
            return generalRequest;
        }

        /// <summary>
        /// Consulta todos los productos
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProducts()
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>()
            {
                Error = false,
                Exception = string.Empty,
                Message = string.Empty,
                Result = products
            };
            return generalRequest;
        }

        /// <summary>
        /// Agrega producto a la base de datos
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> AddProduct(Products product)
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
        /// Edicion de producto en base de datos
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> EditProduct(Products product)
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
        /// Borrado de producto en base de datos
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> DeleteProduct(int productId)
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
        /// Borrado de todos los productos
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> DeleteAllProducts()
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
        /// Agregado de 100000 productos
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> AddMassiveProducts()
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
