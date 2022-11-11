Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ivan")
{
    Console.WriteLine("Ура, это же IVAN!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}