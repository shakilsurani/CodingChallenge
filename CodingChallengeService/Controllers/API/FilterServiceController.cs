using CodingChallengeService.Models;
using CodingChallengeService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodingChallengeService.Controllers.API
{
    public class FilterServiceController : ApiController
    {
        private IFilterService _service = new FilterService();

        public FilterServiceController()
        {

        }

        public FilterServiceController(IFilterService service)
        {
            _service = service;
        }

        public string Get(int id)
        {
            return "Shakil Surani";
        }

        public IHttpActionResult Post([FromBody]Request request)
        {
            var responseValue = _service.GetFilteredResponse(request);
            if (responseValue != null && responseValue.Count < 1)
                return BadRequest("Could not decode request: JSON parsing failed");
            //
            return Ok(responseValue);
        }
    }
}
