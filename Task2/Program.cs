Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Больше");
    Console.WriteLine(number1);
    Console.WriteLine("Меньше");
    Console.WriteLine(number2);
}
else if (number1 < number2)
{
    Console.WriteLine("Больше");
    Console.WriteLine(number2);
    Console.WriteLine("Меньше");
    Console.WriteLine(number1);
}
else if (number1 == number2)
{
    Console.WriteLine("Числа равны");
}
