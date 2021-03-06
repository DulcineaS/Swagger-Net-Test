﻿using Swagger_Test.Models;
using System.Web.Http;

namespace Swagger_Test.Controllers
{
    [RoutePrefix("api/FromUri")]
    public class FromUriController : ApiController
    {
        [Route("Test0_WithFromUri")]
        public IHttpActionResult GetWith0([FromUri] ViewModelTest a, [FromUri] ViewModelTest b)
        {
            return Ok(new { a = a, b = b });
        }

        [Route("Test1_WithFromUri")]
        public ViewModelTest GetWith([FromUri] ViewModelTest v)
        {
            return v;
        }

        [Route("Test2_NoFromUri")]
        public ViewModelTest GetWithout(ViewModelTest v)
        {
            return v;
        }

        public ViewModelTest Post(ViewModelTest v)
        {
            return v;
        }
    }
}
