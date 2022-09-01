Console.Clear();
Console.Write("Введите трехзначное число, чтобы узнать последнюю цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1000 && num > 99)
{
    num = num %10;
    Console.WriteLine(num);
} 
else
{
    Console.WriteLine("Это не трехзначное число");
}