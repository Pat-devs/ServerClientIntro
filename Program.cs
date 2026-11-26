using System.Net.Http.Json;

using HttpClient client = new()
{
    BaseAddress = new Uri(
        "https://jsonplaceholder.typicode.com/"
    ),
    Timeout = TimeSpan.FromSeconds(15)
};

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Show post");
    Console.WriteLine("2. List posts by user");
    Console.WriteLine("3. Show comments");
    Console.WriteLine("4. Create post");
    Console.WriteLine("5. Replace post");
    Console.WriteLine("6. Change title");
    Console.WriteLine("7. Delete post");
    Console.WriteLine("0. Exit");

    Console.Write("Choose: ");

    string? choice = Console.ReadLine();

    if (choice is null || choice == "0")
    {
        break;
    }

    switch (choice)
    {
        case "1":
            Console.WriteLine("GET selected");
            break;

        case "4":
            Console.WriteLine("POST selected");
            break;

        default:
            Console.WriteLine("Not implemented yet.");
            break;
    }
}