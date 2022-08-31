Console.Clear();
Console.WriteLine("ВВедите 2 числа. Мы определим, является ли первое число квадратом второго.");
Console.Write("Введите первое число:  ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:  ");
int numB = Convert.ToInt32(Console.ReadLine());
int sq = numB * numB;
if (sq == numA) Console.WriteLine("Да, это оно!");
if (sq != numA) Console.WriteLine("Оу, это не оно!");