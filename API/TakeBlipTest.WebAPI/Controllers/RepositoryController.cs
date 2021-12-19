using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeBlipTest.Service.Interface;


namespace TakeBlipTest.WebAPI.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class RepositoryController : ControllerBase
    {
        private readonly int amount = 5;
        private readonly string language = "C#";
        private readonly string user = "takenet";
        private readonly IGitHubService _gitHubService;
        public RepositoryController(IGitHubService gitHubService)
        {
            _gitHubService = gitHubService;
        }

        /// <summary>
        /// Get five firts itens from Take repository.
        /// </summary>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var repos = await _gitHubService.GetReposByLanguageAsync(language, amount, user);

            return Ok(repos);
        }
    }
}
