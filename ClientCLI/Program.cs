using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        try
        {
            using var client = new HttpClient();
            var response = await client.GetAsync("http://localhost:5050/great");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiResponse>(json);

            Console.WriteLine(result?.message);
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public class ApiResponse
    {
        public string message { get; set; } = string.Empty;
    }
}