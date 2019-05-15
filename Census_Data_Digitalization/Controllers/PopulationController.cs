using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BAL;
using Shared.DTO;

namespace Census_Data_Digitalization.Controllers
{
    public class PopulationController : ApiController
    {

        IPopulationService serviceCall;
        // GET api/<controller>

        public PopulationController(IPopulationService populationService)
        {
            serviceCall = populationService;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] PopulationDTO ppl)
        {
            if (ModelState.IsValid)
            {
                serviceCall.ServicePostPopulation(ppl);
            }
            else
            {
                ModelState.Values.Select(m => m.Errors);
            }
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