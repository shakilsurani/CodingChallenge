﻿using CodingChallengeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeService.Service
{
    public interface IFilterService
    {
        List<Response> GetFilteredResponse(Request request);
    }
}
