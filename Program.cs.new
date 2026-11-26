using HttpClient client = new();

client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

using HttpResponseMessage response = await client.GetAsync("posts/1");

Console.WriteLine($"Status: {(int)response.StatusCode} {response.StatusCode}");
Console.WriteLine($"Type: {response.Content.Headers.ContentType}");

string json = await response.Content.ReadAsStringAsync();

Console.WriteLine(json);