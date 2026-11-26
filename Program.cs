using System.Net.Http.Json;

using HttpClient client = new();

client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

using HttpResponseMessage response = await client.GetAsync("posts/2");

Console.WriteLine($"Status: {(int)response.StatusCode} {response.StatusCode}");
Console.WriteLine($"Type: {response.Content.Headers.ContentType}");

string json = await response.Content.ReadAsStringAsync();

Console.WriteLine(json);

// DTO - Data Transfer Objects

// Input (JSON)
/* A post
{
  "userId": 1,
  "id": 2,
  "title": "qui est esse",
  "body": "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla"
}
*/

Console.WriteLine("------");

Post post = await response.Content.ReadFromJsonAsync<Post>();

Console.WriteLine($"Post ID: {post.Id}");
Console.WriteLine($"Post UserId: {post.UserId}");
Console.WriteLine($"Post Title: {post.Title}");
Console.WriteLine($"Post Body: {post.Body}");

public class Post
{
    public int UserId { get; set; }
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}


