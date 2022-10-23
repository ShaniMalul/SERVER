using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/CovidDetails")]
    public class CovidDetailsController : ApiController
    {
       CovidBL covidBL = new CovidBL();
        
        [Route("AddDetails"),HttpPost]
        public void AddDetails(CovidDetailsDTO c)
        {
            covidBL.AddDetails(c);
        }


        [Route("GetDetails")]
        [HttpGet]
        public IHttpActionResult GetDetails()
        {
            return Ok(covidBL.GetDetails());
        }
    }
}
