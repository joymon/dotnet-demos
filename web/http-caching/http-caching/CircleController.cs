using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace CurrentUserTests
{
    public class CircleController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public double Get(int id)
        {
            return GetAreaOfCircle(id);
        }
        [Route("api/Circle/{value}/mode/{mode}")]
        public async Task<HttpResponseMessage> Get(int value, int mode)
        {
            double result = GetAreaOfCircle(value);
            var response = Request.CreateResponse(HttpStatusCode.OK, result);
            await HttpResponseCacheHeaderHandler.SetHttpCacheHeaders(response, (ResponseCacheMode)mode);
            return response;
        }

        
        
        
        public double GetAreaOfCircle(int value)
        {
            double radius = Convert.ToDouble(value);
            double pi = GetValueOfPi();
            //client.StopOperation<DependencyTelemetry>(holder);
            return pi * radius * radius;
        }
        private static double GetValueOfPi()
        {
            return 3.14;
        }
        public double FindArea()
        {
            return 30;
        }
        public double FindAreaWithcachecontrol()
        {
            return 30;
        }
        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}