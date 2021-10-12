using LabNet2021.TP4.Entities;
using LabNet2021.TP4.Logic;
using LabNet2021.TP8.WebAPI.Models;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LabNet2021.TP8.WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CategoriesController : ApiController
    {
        CategoriesLogic categoriesLogic = new CategoriesLogic();

        // GET: api/Categories
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var categories = categoriesLogic.GetAll();

                return Ok(categories);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ha ocurrido un error: {ex.Message}");
                throw;
            }
        }

        // POST: api/Categories
        [HttpPost]
        public IHttpActionResult Post([FromBody] CategoriesView categoriesView)
        {
            try
            {
                Categories categoryEntity = new Categories
                {
                    CategoryName = categoriesView.Category,
                    Description = categoriesView.Description
                };

                categoriesLogic.Add(categoryEntity);

                return Ok("¡Operación exitosa!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Ha ocurrido un error: {ex.Message}");
                throw;
            }
        }

        // PUT: api/Categories/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] CategoriesView categoriesView)
        {
            try
            {
                Categories categoryEntity = new Categories
                {
                    CategoryID = id,
                    CategoryName = categoriesView.Category,
                    Description = categoriesView.Description
                };

                categoriesLogic.Update(categoryEntity);

                return Ok("¡Operación exitosa!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Ha ocurrido un error: {ex.Message}");
                throw;
            }
        }

        // DELETE: api/Categories/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                categoriesLogic.Delete(id);

                return Ok("¡Operación exitosa!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Ha ocurrido un error: {ex.Message}");
                throw;
            }
        }
    }
}
