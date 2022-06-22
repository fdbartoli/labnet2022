using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Tp04.EntityFramework.Entities;
using Tp04.EntityFramework.Logic;
using Tp08.WebAPI.Models;

namespace Tp08.WebAPI.Controllers
{
    public class SuppliersController : ApiController
    {
        readonly SuppliersLogic logic = new SuppliersLogic();
        
        // GET api/values
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

        // GET api/values/5
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

        // POST api/values
        [HttpPost]
        public IHttpActionResult Post([FromUri] SuppliersView suppliersRequest)
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
                return Content(HttpStatusCode.BadRequest, e.Message);
            }
        }

        // PUT api/values/5
        [HttpPatch]
        public IHttpActionResult Edit([FromBody] SuppliersView suppliersRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
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

        // DELETE api/values/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                logic.Remove(id);
                return Ok();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
