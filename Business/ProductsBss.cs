using Data;
using Domain;
using Domain.Models;
using Domain.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Business
{
    public class ProductsBss
    {
        private readonly IProductsDat _productsDat;

        public ProductsBss()
        {
            _productsDat = new ProductsDat();
        }

        /// <summary>
        /// Comunmente utilizado para pruebas unitarias por inyeccion de dependencias
        /// </summary>
        /// <param name="categoriesDat"></param>
        public ProductsBss(IProductsDat productsDat)
        {
            _productsDat = productsDat;
        }

        /// <summary>
        /// Consulta un solo producto de base de datos
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public GeneralRequest<Products> SelectProduct(int productId)
        {
            GeneralRequest<Products> generalRequest = new GeneralRequest<Products>();
            try
            {
                generalRequest = _productsDat.SelectProduct(productId);
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
        /// Consulta los productos por nombre
        /// </summary>
        /// <param name="findProductsByName"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProductsByProductName(FindProductsByName findProductsByName)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                generalRequest = _productsDat.SelectProductsByProductName(findProductsByName);
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
        /// Consulta los productos por descripcion
        /// </summary>
        /// <param name="findProductsByDescription"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProductsByProductDescription(FindProductsByDescription findProductsByDescription)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                generalRequest = _productsDat.SelectProductsByProductDescription(findProductsByDescription);
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
        /// Consulta los productos por categorias
        /// </summary>
        /// <param name="findProductsByCategory"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProductsByCategory(FindProductsByCategory findProductsByCategory)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                generalRequest = _productsDat.SelectProductsByCategory(findProductsByCategory);
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
        /// Consulta todos los productos
        /// </summary>
        /// <returns></returns>
        public GeneralRequest<List<Products>> SelectProducts(FindAllProducts findAllProducts)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                generalRequest = _productsDat.SelectProducts(findAllProducts);
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
        /// Agrega producto a la base de datos
        /// </summary>
        /// <param name="product"></param>
        public GeneralRequest<bool> AddProduct(Products product)
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            try
            {
                generalRequest = _productsDat.AddProduct(product);
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
        /// Edicion de producto en base de datos
        /// </summary>
        /// <param name="product"></param>
        public GeneralRequest<bool> EditProduct(Products product)
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            try
            {
                generalRequest = _productsDat.EditProduct(product);
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
        /// Borrado de producto en base de datos
        /// </summary>
        /// <param name="product"></param>
        public GeneralRequest<bool> DeleteProduct(int productId)
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            try
            {
                generalRequest = _productsDat.DeleteProduct(productId);
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
