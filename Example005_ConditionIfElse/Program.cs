Console.Write("Enter user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "bob")  //ToLower приводит к прописным буквам
{
    Console.WriteLine("Wow! It's Bob!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
