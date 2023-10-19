//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число: ");
string LineNumber = Console.ReadLine();
int number;
bool isNumber = int.TryParse(LineNumber, out number);
while (isNumber == false | number < 100 | number > 999)
    {
        Console.WriteLine("Неверный формат, введите трёхзначное число: ");
        LineNumber = Console.ReadLine();
        isNumber = int.TryParse(LineNumber, out number);
    }
Console.Write($"{number} -> {(number / 10) % 10}");