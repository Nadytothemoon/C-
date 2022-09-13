Console.Write ("Введите имя пользователя:");
string username = Console. ReadLine();

if (username. ToLower() == "nady")
{
    Console.WriteLine ("Ура, это же Nady!!!");
}
else
{
    Console.Write ("Hello,");
    Console.WriteLine (username);
}