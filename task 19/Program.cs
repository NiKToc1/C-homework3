Console.Clear();
Console.WriteLine("Введите пятизначное число:");
string s = Console.ReadLine();

if(s.Length == 5)
{
    if(s[0] == s[4] || s[1] == s[3])
    Console.WriteLine("Палиндром");
    else Console.WriteLine("Не палиндром");
}
else Console.WriteLine("Неверное число");