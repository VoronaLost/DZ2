//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите любое число: ");
string LineNumber = Console.ReadLine();
int number;
bool isNumber = int.TryParse(LineNumber, out number);
while (isNumber == false)
    {
        Console.WriteLine("Неверный формат, введите любое число: ");
        LineNumber = Console.ReadLine();
        isNumber = int.TryParse(LineNumber, out number);
    }
if (number >= 100)
    {
        int cutdigits = number / Convert.ToInt32(Math.Pow(10, LineNumber.Length-3));
        // cutdigits - трёхзначное число, получаемое после отсечения лишних разрядов от искомого числа
        Console.Write($"{number} -> {cutdigits % 10}");
    }
else 
        Console.WriteLine("третьей цифры нет");

