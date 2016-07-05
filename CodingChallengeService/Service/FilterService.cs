using CodingChallengeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingChallengeService.Service
{
    public class FilterService : IFilterService
    {
        public List<Response> GetFilteredResponse(Request request)
        {
            List<Response> returnValue = new List<Response>();
            //
            if (request != null && request.Payload != null && request.Payload.Count > 0)
            {
                returnValue = request.Payload.Where(x => x.Drm == true && x.EpisodeCount > 0)
                                             .Select(s => new Response { image = s.Image.ShowImage, slug = s.Slug, title = s.Title })
                                             .Skip(request.Skip).Take(request.Take).ToList();
            }
            //
            return returnValue;
        }
    }
}