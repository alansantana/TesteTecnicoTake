using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TakeBlipTest.Model;
using RestEase;


namespace TakeBlipTest.Service.Interface
{

    [Header("Accept", "application/vnd.github.v3+json")]
    [Header("User-Agent", "RestEase Sample")]
    public interface IGitHubClient
    {
        [Get("users/{username}/repos")]
        Task<IEnumerable<GitHubRepository>> GetReposAsync(
            [Path("username")] string username,
            [Query("sort")] string sort,
            [Query("direction")] string direction);
    }

}
