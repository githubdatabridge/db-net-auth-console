using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                await Task.Delay(2000);
                var values = new Dictionary<string, string>
                {
                     {"client_id", "498542bd-1412-44e9-ae97-d621f1971392"},
                     {"scope", "api://498542bd-1412-44e9-ae97-d621f1971392/.default"},
                     {"client_secret", "aqKozwHNFZYiDko49MI/reWaaPv+74Q/lpRHRgH7l/M="},
                     {"grant_type", "client_credentials"}
                };

                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync("https://login.microsoftonline.com/473672ba-cd07-4371-a2ae-788b4c61840e/oauth2/v2.0/token", content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);
                Console.WriteLine("--------------------------------------------------------------------");
                i++;
            }
        }
    }
}
