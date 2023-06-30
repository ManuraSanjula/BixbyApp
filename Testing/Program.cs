using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyWebServer.Tests
{
    public class WebServerTests
    {
        private const string BaseUrl = "http://localhost:8080";

        public async Task RunTests()
        {
            var client = new HttpClient();

            await TestHomeRequest(client);
            await TestAboutRequest(client);
            await TestFileRequest(client);
        }

        private async Task TestHomeRequest(HttpClient client)
        {
            var response = await client.GetAsync($"{BaseUrl}/");
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Home request response: {content}");
        }

        private async Task TestAboutRequest(HttpClient client)
        {
            var response = await client.GetAsync($"{BaseUrl}/about");
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"About request response: {content}");
        }

        private async Task TestFileRequest(HttpClient client)
        {
            // Replace "path_to_your_file" with the actual file path you want to test
            var response = await client.GetAsync($"{BaseUrl}/file");
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"File request response: {content}");
        }
    }

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var tests = new WebServerTests();
            await tests.RunTests();

            Console.WriteLine("Tests completed. Press any key to exit...");
            Console.ReadKey();
        }
    }
}