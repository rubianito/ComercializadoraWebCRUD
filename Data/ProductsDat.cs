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
        /// <param name="productName"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProductsByProductName(string productName)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    generalRequest.Result = ctx.Products.Where(x => x.ProductName == productName).ToList();
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
        /// <param name="productDescription"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProductsByProductDescription(string productDescription)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    generalRequest.Result = ctx.Products.Where(x => x.ProductDescription == productDescription).ToList();
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
        /// <param name="categoryId"></param>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<List<Products>> SelectProductsByCategory(int categoryId)
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    generalRequest.Result = ctx.Products.Where(x => x.CategoryId == categoryId).ToList();
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
        public GeneralRequest<List<Products>> SelectProducts()
        {
            GeneralRequest<List<Products>> generalRequest = new GeneralRequest<List<Products>>();
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    generalRequest.Result = ctx.Products.Select(x => x).ToList();
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

        /// <summary>
        /// Borrado de todos los productos
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> DeleteAllProducts()
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            generalRequest.Result = true;
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    ctx.sp_DeleteAllProducts();
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
        /// Agregado de 100000 productos
        /// </summary>
        /// <returns>Objeto generico para manejo de excepciones</returns>
        public GeneralRequest<bool> AddMassiveProducts()
        {
            GeneralRequest<bool> generalRequest = new GeneralRequest<bool>();
            generalRequest.Result = true;
            try
            {
                using (var ctx = new ComercializadoraDbEntities1())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    ctx.sp_CreateMassiveProducts();
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
