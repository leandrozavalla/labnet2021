using LabNet2021.TP4.Entities;
using LabNet2021.TP4.Logic;
using LabNet2021.TP8.WebAPI.Models;
using System;
using System.Web.Http;

namespace LabNet2021.TP8.WebAPI.Controllers
{
    public class ShippersController : ApiController
    {
        ShippersLogic shippersLogic = new ShippersLogic();

        // GET: api/Shippers
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var shippers = shippersLogic.GetAll();

                return Ok(shippers);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ha ocurrido un error: {ex.Message}");
                throw;
            }
        }

        // POST: api/Shippers
        [HttpPost]
        public IHttpActionResult Post([FromBody] ShippersView shippersView)
        {
            try
            {
                Shippers shipperEntity = new Shippers
                {
                    CompanyName = shippersView.Company,
                    Phone = shippersView.Phone
                };

                shippersLogic.Add(shipperEntity);

                return Ok("¡Operación exitosa!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Ha ocurrido un error: {ex.Message}");
                throw;
            }
        }

        // PUT: api/Shippers/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] ShippersView shippersView)
        {
            try
            {
                Shippers shipperEntity = new Shippers
                {
                    ShipperID = id,
                    CompanyName = shippersView.Company,
                    Phone = shippersView.Phone
                };

                shippersLogic.Update(shipperEntity);

                return Ok("¡Operación exitosa!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Ha ocurrido un error: {ex.Message}");
                throw;
            }
        }

        // DELETE: api/Shippers/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                shippersLogic.Delete(id);

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
