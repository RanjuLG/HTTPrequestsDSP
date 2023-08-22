namespace HttpClientStatus;

class Program
{
    static async Task Main(string[] args)
    {
        using var client = new HttpClient();

        var result = await client.GetAsync("http://10.20.30.198:8013/api/status");
        Console.WriteLine(result.StatusCode);
    }
}