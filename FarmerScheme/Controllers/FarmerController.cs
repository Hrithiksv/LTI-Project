using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FarmerScheme.Models;
using System.Web.Http.Cors;
namespace FarmerScheme.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FarmerController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetFarmer()
        {
            using (FarmerSchemeEntities db = new FarmerSchemeEntities())
            {
                var data = db.Farmers.ToList();
                if (data != null)
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                else
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Former does not exist");
            }
        }

        [HttpGet]
        public HttpResponseMessage GetFarmer(int id)
        {
            using (FarmerSchemeEntities db = new FarmerSchemeEntities())
            {
                var data = db.Farmers.Find(id);

                if (data != null)
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                else
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Former with id " + id + " does not exist");
            }
        }

        [HttpPost]
        public HttpResponseMessage PostFarmer([FromBody] Farmer farmer)
        {
            try
            {
                using(FarmerSchemeEntities db=new FarmerSchemeEntities())
                {
                    db.Farmers.Add(farmer);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created);
                }
            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }


    }
}
