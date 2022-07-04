using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebAPIClient
{
    //class Program
    //{
    //    private static readonly HttpClient client = new HttpClient();
    //    private static IEnumerable<object> repositories;

    //    public static async Task Main(string[] args)
    //    {
    //        var repositories = await ProcessRepositories();
    //        foreach (var repo in repositories)
    //        {
    //            Console.WriteLine(repo.name);
    //            Console.WriteLine(repo.gitHubHomeUrl);
    //            Console.WriteLine(repo.homePage);
    //            Console.WriteLine(repo.Watchers);
    //            Console.Write(repo.LastPushedUtc);
    //            Console.WriteLine();
    //        }
    //        await ProcessRepositories();
    //    }

    //private static async Task <List<repo>> ProcessRepositories()
    //{
    //    client.DefaultRequestHeaders.Accept.Clear();
    //    client.DefaultRequestHeaders.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
    //    client.DefaultRequestHeaders.Add("User-Agent", "NET Foundation Repository Reporter");

    //    var streamTask = client.GetAsync("https://api.github.com/orgs/dotnet/repos");
    //    //var repositories = await JsonSerializer.DeserializeAsync<List<repo>>(await streamTask);
    //    return repositories;

    //    //foreach (var repo in repositories)
    //    //{
    //    //    Console.WriteLine(repo.name);
    //    //}


    //        }
    //    }
    //}
}
