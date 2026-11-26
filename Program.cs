using System.Net.Http.Json;

using HttpClient client = new();

client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

// https://jsonplaceholder.typicode.com/posts?userId=1  ´// this one has server side filtering
// https://jsonplaceholder.typicode.com/posts // this one is unfiltered

using HttpResponseMessage response = await client.GetAsync("posts");

Console.WriteLine($"Status: {(int)response.StatusCode} {response.StatusCode}");
Console.WriteLine($"Type: {response.Content.Headers.ContentType}");

string json = await response.Content.ReadAsStringAsync();

Console.WriteLine(json);

Console.WriteLine("------");

// Post post = await response.Content.ReadFromJsonAsync<Post>();

List<Post> posts = await response.Content.ReadFromJsonAsync<List<Post>>();

Console.WriteLine($"Post count: {posts.Count}");

foreach (Post post in posts)
{
    if (post.UserId == 1) Console.WriteLine($"Post ID & Title: {post.Id} - {post.Title}");
}



public class Post
{
    public int UserId { get; set; }
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}


