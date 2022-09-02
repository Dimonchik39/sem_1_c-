Console.Clear();
Console.Write("Введите число, чтобы увидеть все целые промежуточные числа: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = -num;
while (count <= num)
{
    Console.Write($"{count}, ");
    count ++;
}
