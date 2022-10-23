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
    [RoutePrefix("api/HMOmember")]
    public class HMOmemberController : ApiController
    {
        MemberBL memBL = new MemberBL();

        [Route("AddMember"), HttpPost]
        public void AddMember(HMOmemberDTO m)
        {
            memBL.AddMember(m);
        }

        [Route("UpdateMember"), HttpPost]
        public void UpdateMember(HMOmemberDTO m)
        {
            memBL.UpdateMember(m);
        }


        [Route("GetMembers")]
        [HttpGet]
        public IHttpActionResult GetMembers()
        {
            return Ok(memBL.GetMembers());
        }

        [Route("DeleteMember/{i}")]
        [HttpDelete]
        public IHttpActionResult DeleteMember(int i)
        {
            memBL.DeleteMember(i);
            return Ok(true);
        }


    }
}
