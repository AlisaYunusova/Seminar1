//сравниить три числа между собой и найти самое большое
Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxnumber = 0;

if (number1 > number2)
{
    maxnumber = number1;
}
else
{
    maxnumber = number2;
}
if (maxnumber > number3)
{
    Console.WriteLine(maxnumber);
}
else
{
    Console.WriteLine(number3);
}
