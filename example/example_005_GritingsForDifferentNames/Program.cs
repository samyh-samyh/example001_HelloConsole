Console.Write("Enter the username: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Hey, Masha! You`re look amazing!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}