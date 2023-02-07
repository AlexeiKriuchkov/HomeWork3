// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

double number = ReadInt("Введите число: ");

for (double i = 1; i <= number; i+=0.5)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}
double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}