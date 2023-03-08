using Domain;
using Domain.Models;
using Domain.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    /// <summary>
    /// Gestion de productos en base de datos
    /// </summary>
    public class ProductsDat : IProductsDat
    {
        /// <summary>
        /// Consulta un solo producto de base de datos
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<Products> SelectProduct(int productId)
        {
            GeneralRequest<Products> generalRequest = new GeneralRequest<Products>();
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    generalRequest.Result = ctx.Products.Where(x => x.ProductId == productId).FirstOrDefault();
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
        /// Consulta los productos por nombre
        /// </summary>
        /// <param name="findProductsByName"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProductsByProductName(FindProductsByName findProductsByName)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    generalRequest.Result = ctx.Products.Where(x => x.ProductName == findProductsByName.ProductName).ToList();
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
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    generalRequest.Result = ctx.Products.Where(x => x.ProductDescription == findProductsByDescription.ProductDescription).ToList();
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
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    generalRequest.Result = ctx.Products.Where(x => x.CategoryId == findProductsByCategory.CategoryId).ToList();
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
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProducts(FindAllProducts findAllProducts)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    generalRequest.Result = ctx.Products.Select(x => x).ToList();
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
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> AddProduct(Products product)
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            generalRequest.Result = true;
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    ctx.Products.Add(product);
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
        /// Edicion de producto en base de datos
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> EditProduct(Products product)
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            generalRequest.Result = true;
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    var productToEdit = ctx.Products.Where(x => x.ProductId == product.ProductId).FirstOrDefault();
                    productToEdit.ProductName = product.ProductName;
                    productToEdit.ProductImage = product.ProductImage;
                    productToEdit.ProductDescription = product.ProductDescription;
                    productToEdit.CategoryId = product.CategoryId;
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
        /// Borrado de producto en base de datos
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> DeleteProduct(int productId)
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            generalRequest.Result = true;
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    var productToDelete = ctx.Products.Where(x => x.ProductId == productId).FirstOrDefault();
                    ctx.Products.Remove(productToDelete);
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
