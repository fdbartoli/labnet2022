using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
                    Phone = s.Phone
                }).ToList();

                return Ok(suppliersView);
                       
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IHttpActionResult Post([FromUri] SuppliersView suppliersRequest)
        {
            return "value";
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
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
