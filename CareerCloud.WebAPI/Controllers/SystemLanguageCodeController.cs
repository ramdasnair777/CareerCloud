﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WebAPI.Controllers
{
    [RoutePrefix("api/careercloud/system/v1")]
    public class SystemLanguageCodeController : ApiController
    {
        private SystemLanguageCodeLogic _logic;

        public SystemLanguageCodeController()
        {
            var repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            _logic = new SystemLanguageCodeLogic(repo);
        }
        [HttpGet]
        [Route("languagecode/{id}")] 
        [ResponseType(typeof(SystemLanguageCodePoco))]
        public IHttpActionResult GetSystemLanguageCode(string id)
        {
            SystemLanguageCodePoco poco = _logic.Get(id);
            if (poco == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(poco);
            }
        }
        [HttpGet]
        [Route("languagecode")]
        [ResponseType(typeof(List<SystemLanguageCodePoco>))]
        public IHttpActionResult GetAllSystemLanguageCode()
        {
            List<SystemLanguageCodePoco> result = _logic.GetAll();
            if(result==null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        [Route("languagecode")]
        public IHttpActionResult PostSystemLanguageCode
            ([FromBody] SystemLanguageCodePoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }
        [HttpPut]
        [Route("languagecode")]
        public IHttpActionResult PutSystemLanguageCode
            ([FromBody] SystemLanguageCodePoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }
        [HttpDelete]
        [Route("languagecode")]
        public IHttpActionResult DeleteSystemLanguageCode
            ([FromBody] SystemLanguageCodePoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
