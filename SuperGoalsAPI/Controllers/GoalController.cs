using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SuperGoalsAPI.DTOs;
using System;
using System.Collections.Generic;

namespace SuperGoalsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoalController : ControllerBase
    {
        private readonly ILogger _logger;

        // TODO remove this once I get logger figured out for test project
        public GoalController()
        {

        }

        public GoalController(ILogger<GoalController> logger)
        {
            _logger = logger;
        }

        public IActionResult GetAllGoals(Guid accountId)
        {
            List<Goal> goalList = new List<Goal>();

            // TODO add service call to get the list from the repository

            return Ok(goalList); 

        }
    }
}
