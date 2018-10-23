using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task t = new Task(DownloadPageAsync);
        t.Start();
        Console.WriteLine("Downloading page...");
        Console.ReadLine();
    }

    static async void DownloadPageAsync()
    {
        // ... Target page.
        string page = "http://en.wikipedia.org/";

        // ... Use HttpClient.
        using (HttpClient client = new HttpClient())
        using (HttpResponseMessage response = await client.GetAsync(page))
        using (HttpContent content = response.Content)
        {
            // ... Read the string.
            string result = await content.ReadAsStringAsync();

            // ... Display the result.
            if (result != null &&
            result.Length >= 50)
            {
                Console.WriteLine(result.Substring(0, 50) + "...");
            }
        }
    }
}
// OUTPUT:
/*
Downloading page...
<!DOCTYPE html>
<html lang="en" dir="ltr" class="c...
*/