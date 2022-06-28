using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Tp04.EntityFramework.Entities;
using Tp04.EntityFramework.Logic;
using Tp08.WebAPI.Models;
using System.Web.Http.Cors;


namespace Tp08.WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class SuppliersController : ApiControllers
    {
        readonly SuppliersLogic logic = new SuppliersLogic();

 
        public IHttpActionResult Get()
        {
            try
            {
                List<Suppliers> suppliers = logic.GetAll();
                List<SuppliersView> suppliersView = suppliers.Select(s => new SuppliersView
                {
                    Id = s.SupplierID,
                    CompanyName = s.CompanyName,
                    ContactName = s.ContactName,
                    Phone =   s.Phone
                }).ToList();

                return Ok(suppliersView);
                       
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.BadRequest, e.Message);
            }
        }


        public IHttpActionResult Get(int id)
        {
            try
            {
                Suppliers supplier = logic.GetOneByID(id);
                SuppliersView supplierResponse = new SuppliersView
                {
                    Id = supplier.SupplierID,
                    CompanyName = supplier.CompanyName,
                    ContactName = supplier.ContactName,
                    Phone = supplier.Phone,
                };
                return Ok(supplierResponse);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.NotFound, e.Message);
            }
        }

        // POST: Create
        [HttpPost]
        public IHttpActionResult Post([FromBody] SuppliersView suppliersRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Suppliers suppliersEntity = new Suppliers
                {
                    CompanyName = suppliersRequest.CompanyName,
                    ContactName = suppliersRequest.ContactName,
                    Phone = suppliersRequest.Phone,
                };
                logic.Add(suppliersEntity);
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }

        //PATCH: api/Suppliers/5
        [HttpPatch]
        public IHttpActionResult Edit([FromBody] SuppliersView suppliersRequest)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Error, ID vacío");
            }
            try
            {
                Suppliers suppliersEntity = new Suppliers
                {
                    SupplierID = suppliersRequest.Id,
                    CompanyName = suppliersRequest.CompanyName,
                    ContactName = suppliersRequest.ContactName,
                    Phone = suppliersRequest.Phone,
                };
                logic.Update(suppliersEntity);
                return Ok();

            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.NotFound, e.Message);
            }
        }

        // DELETE api/Suppliers/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                logic.Remove(id);
                return Ok();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                return Content(HttpStatusCode.NotFound, "Este ID esta relacionado con otros campos");
            }
            catch (Exception)
            {
                return Content(HttpStatusCode.NotFound, "No es posible eliminar este registro"); ;
            }

        }
    }
}
