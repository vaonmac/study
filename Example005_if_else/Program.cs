// Оператор ветвления. Задача на приветствие особенного пользователя
Console.WriteLine("Введите Ваше имя");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.Write("Да это же ");
    Console.Write(username);
    Console.WriteLine("!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}