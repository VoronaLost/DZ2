//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите № дня недели, чтобы узнать является ли он выходным: ");
string LineNumber = Console.ReadLine();
int number;
bool isNumber = int.TryParse(LineNumber, out number);
while (isNumber == false | number < 1 | number > 7)
    {
        Console.WriteLine("Неверный формат, введите № дня недели, чтобы узнать является ли он выходным: ");
        LineNumber = Console.ReadLine();
        isNumber = int.TryParse(LineNumber, out number);
    }
if (number == 6 | number == 7)
Console.Write($"{number} -> да");
else
Console.Write($"{number} -> нет");