using Business;
using Domain;
using Domain.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ComercializadoraWeb
{
    [Route("api/[controller]")]
    public class CategoriesApi : ApiController
    {
        //[HttpPost]
        //[Route("GenerarToken")]
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        [Route("SelectCategory")]
        public  GeneralRequest<Categories> SelectCategory(int categoryId)
        {
            CategoriesBss categoriesBss = new CategoriesBss();
            return categoriesBss.SelectCategory(categoryId);
        }
    }
}