using System.Diagnostics;
using System.Net;
using System.Text;

namespace HTTPClient;

class Program
{
    static async Task Main(string[] args)

    {

        var url = "http://10.20.30.198:8013/api/status/";

        using var client = new HttpClient();

        var result = await client.GetAsync(url);

        try
        {
        
            var content = await client.GetStringAsync(url);

            Console.WriteLine("Status Code: " + (int)result.StatusCode);
            Console.WriteLine("Response Message: "+result.StatusCode);
            Console.WriteLine("Complete Header Response: " + result);
            Console.WriteLine("Content: " + content);
            

            Console.Read();
        }
        catch (Exception) {

            Console.WriteLine("Status Code: " + (int)result.StatusCode);
            Console.WriteLine("Response Message: " + result.StatusCode);
            Console.WriteLine("Complete Header Response: " + result);
        }


    }
}
