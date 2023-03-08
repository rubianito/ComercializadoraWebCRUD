using Data;
using Domain;
using Domain.Models;
using Domain.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

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
                generalRequest = _productsDat.SelectProductsByProductName(findProductsByName.ProductName);

                if (findProductsByName.OrderByDescription)
                {
                    if (findProductsByName.DescriptionAscending)
                    {
                        generalRequest.Result = generalRequest.Result.OrderBy(x => x.ProductDescription).ToList();
                    }
                    else
                    {
                        generalRequest.Result = generalRequest.Result.OrderByDescending(x => x.ProductDescription).ToList();
                    }
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
        /// Consulta los productos por descripcion
        /// </summary>
        /// <param name="findProductsByDescription"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProductsByProductDescription(FindProductsByDescription findProductsByDescription)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                generalRequest = _productsDat.SelectProductsByProductDescription(findProductsByDescription.ProductDescription);
                if (findProductsByDescription.OrderByName)
                {
                    if (findProductsByDescription.NameAscending)
                    {
                        generalRequest.Result = generalRequest.Result.OrderBy(x => x.ProductName).ToList();
                    }
                    else
                    {
                        generalRequest.Result = generalRequest.Result.OrderByDescending(x => x.ProductName).ToList();
                    }
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
        /// Consulta los productos por categorias
        /// </summary>
        /// <param name="findProductsByCategory"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProductsByCategory(FindProductsByCategory findProductsByCategory)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                generalRequest = _productsDat.SelectProductsByCategory(findProductsByCategory.CategoryId);
                if (findProductsByCategory.OrderByName)
                {
                    if (findProductsByCategory.NameAscending)
                    {
                        generalRequest.Result = generalRequest.Result.OrderBy(x => x.ProductName).ToList();
                    }
                    else
                    {
                        generalRequest.Result = generalRequest.Result.OrderByDescending(x => x.ProductName).ToList();
                    }
                }

                if (findProductsByCategory.OrderByDescription)
                {
                    if (findProductsByCategory.DescriptionAscending)
                    {
                        generalRequest.Result = generalRequest.Result.OrderBy(x => x.ProductDescription).ToList();
                    }
                    else
                    {
                        generalRequest.Result = generalRequest.Result.OrderByDescending(x => x.ProductDescription).ToList();
                    }
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
        /// Consulta todos los productos
        /// </summary>
        /// <returns></returns>
        public GeneralRequest<List<Products>> SelectProducts(FindAllProducts findAllProducts)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                generalRequest = _productsDat.SelectProducts();
                if (findAllProducts.OrderByName)
                {
                    if (findAllProducts.NameAscending)
                    {
                        generalRequest.Result = generalRequest.Result.OrderBy(x => x.ProductName).ToList();
                    }
                    else
                    {
                        generalRequest.Result = generalRequest.Result.OrderByDescending(x => x.ProductName).ToList();
                    }
                }

                if (findAllProducts.OrderByDescription)
                {
                    if (findAllProducts.DescriptionAscending)
                    {
                        generalRequest.Result = generalRequest.Result.OrderBy(x => x.ProductDescription).ToList();
                    }
                    else
                    {
                        generalRequest.Result = generalRequest.Result.OrderByDescending(x => x.ProductDescription).ToList();
                    }
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

        /// <summary>
        /// Borrado de todos los productos
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> DeleteAllProducts()
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            try
            {
                generalRequest = _productsDat.DeleteAllProducts();
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
        /// Agregado de 100000 productos
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> AddMassiveProducts()
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            try
            {
                generalRequest = _productsDat.AddMassiveProducts();
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
