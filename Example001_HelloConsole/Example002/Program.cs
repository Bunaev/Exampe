Console.WriteLine("Введите имя");
string username = Console.ReadLine();
if(username.ToLower() == "Маша")
{
    Console.WriteLine("Маша - пять рублей и наша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}