using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TakeBlipTest.Model;

namespace TakeBlipTest.Service.Interface
{
    public interface IGitHubService
    {
        Task<IEnumerable<GitHubRepository>> GetReposByLanguageAsync(string language, int totalReturn, string user);
    }
}
