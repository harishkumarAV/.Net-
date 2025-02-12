//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncProgrammingDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Fetching data...");
            string data = await FetchDataAsync("https://jsonplaceholder.typicode.com/posts");
            Console.WriteLine("Data fetched:");
            Console.WriteLine(data);
        }

        static async Task<string> FetchDataAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseData = await response.Content.ReadAsStringAsync();
                return responseData;
            }
        }
    }
}