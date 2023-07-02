Console.Write("Введите имя пользователя: ");

string username = Console.ReadLine();

if(username.ToLower() == "anton")
{
    Console.WriteLine("Ура, это Anton");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}