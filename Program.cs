using System.Net.Http.Json;

using HttpClient client = new();

// https://jsonplaceholder.typicode.com/users/1
/*
{
  "id": 1,
  "name": "Leanne Graham",
  "username": "Bret",
  "email": "Sincere@april.biz",
  "address": {
    "street": "Kulas Light",
    "suite": "Apt. 556",
    "city": "Gwenborough",
    "zipcode": "92998-3874",
    "geo": {
      "lat": "-37.3159",
      "lng": "81.1496"
    }
  },
  "phone": "1-770-736-8031 x56442",
  "website": "hildegard.org",
  "company": {
    "name": "Romaguera-Crona",
    "catchPhrase": "Multi-layered client-server neural-net",
    "bs": "harness real-time e-markets"
  }
}
*/


client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");


using HttpResponseMessage response = await client.GetAsync("posts?userId=1");

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
    User author = await client.GetFromJsonAsync<User>($"users/{post.UserId}");

    Console.WriteLine($"Post ID & Title: {post.Id} - {post.Title}");
    Console.WriteLine($"Written by authorname: {author.Name}");
}



Console.WriteLine("======");

List<Comment> comments = await client.GetFromJsonAsync<List<Comment>>($"posts/1/comments");

Console.WriteLine($"Comment count: {comments.Count}");

foreach (Comment comment in comments)
{
    Console.WriteLine($"Comment email addr.: {comment.Email}");
    Console.WriteLine($"Comment: {comment.Body}");
}


public class Post
{
    public int UserId { get; set; }
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

/*
  {
    "postId": 1,
    "id": 1,
    "name": "id labore ex et quam laborum",
    "email": "Eliseo@gardner.biz",
    "body": "laudantium enim quasi est quidem magnam voluptate ipsam eos\ntempora quo necessitatibus\ndolor quam autem quasi\nreiciendis et nam sapiente accusantium"
  },
*/
public class Comment
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Body { get; set; }
}