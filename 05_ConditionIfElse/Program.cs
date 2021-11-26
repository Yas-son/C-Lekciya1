//Начало
//Ввести имя пользователя
//ЕСЛИ имя пользователя совпадает с “Маша” то…
//поприветствовать по особенному
//ИНАЧЕ поприветствовать по обычному
//Конец

Console.Write("Ведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}