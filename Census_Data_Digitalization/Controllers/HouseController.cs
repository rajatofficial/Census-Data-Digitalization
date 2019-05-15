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
    public class HouseController : ApiController
    {
        IHouseService serviceCall;
        // GET api/<controller>

            public HouseController(IHouseService houseService)
        {
            serviceCall = houseService;
        }

        public IEnumerable<object> Get()
        {
            return serviceCall.HGraphService();
        }

        // GET api/<controller>/5
        public bool Get(int id)
        {
            return serviceCall.ServiceFindCensusNumber(id);
        }

        // POST api/<controller>

        public int Post([FromBody] HouseDTO house)
        {
            if (ModelState.IsValid)
            {
                return serviceCall.ServicePostHouse(house);
            }
            else
            {
                return 0;
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