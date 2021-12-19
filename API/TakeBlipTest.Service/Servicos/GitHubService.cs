using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeBlipTest.Model;
using TakeBlipTest.Service.Interface;


namespace TakeBlipTest.Service.Servicos
{
    public class GitHubService : IGitHubService
    {
        private readonly IGitHubClient _gitHubClient;
        public GitHubService(IGitHubClient gitHubClient)
        {
            _gitHubClient = gitHubClient;
        }
        public async Task<IEnumerable<GitHubRepository>> GetReposByLanguageAsync(string language, int totalReturn, string user)
        {
            IEnumerable<GitHubRepository> repos = await _gitHubClient.GetReposAsync(user, "created", "asc");

            var result = repos.Where(x => x.Language == language).OrderBy(x => x.CreatedAt.DateTime).Take(totalReturn);

            return result;
        }
    }
}
