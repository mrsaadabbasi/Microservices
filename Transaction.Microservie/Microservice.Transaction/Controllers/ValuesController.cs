﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Microservice.Transaction.Controllers
{
    public class TransactionsController : ApiController
    {
        // GET api/values
        public string Get()
        {
            var resp = File.ReadAllText(@"F:\Microservices Tutorial\MicroService\Transaction.Microservie\Microservice.Transaction\File\fundingResp.txt");
            return resp;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
