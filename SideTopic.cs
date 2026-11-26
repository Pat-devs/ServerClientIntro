
// V1:
for (int i = 1; i <= 10; i++)
{
    using HttpClient client = new();

    Console.WriteLine(await client.GetStringAsync($"https://jsonplaceholder.typicode.com/posts/{i}"));
}




// V2: 
using HttpClient client = new();

for (int i = 1; i <= 10; i++)
{

    Console.WriteLine(await client.GetStringAsync($"https://jsonplaceholder.typicode.com/posts/{i}"));
}