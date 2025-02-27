Console.Write("Введите имя пользователя:");
string userName = Console.ReadLine();
if (userName.ToLower() == "маша") 
{
    Console.WriteLine("Привет, это же " + userName + "!");
}
else
{
    Console.WriteLine("Привет");
    Console.WriteLine(userName);
}
