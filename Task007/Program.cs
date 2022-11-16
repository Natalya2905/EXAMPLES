//7. Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает последнюю цифру
//этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.WriteLine ("Введите трёхзначное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 > 99 && number1 <1000)
{
Console.Write ("последняя цифра:  ");
Console.WriteLine (number1 % 10);
}

else Console.WriteLine ("Введите трёхзначное число");
