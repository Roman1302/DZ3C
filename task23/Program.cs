/* Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Программа вывода кубов чисел от 1 до N");
Console.WriteLine("Введите крайнее число для вычесления куба: ");

string number = Console.ReadLine();
int n = int.Parse(number);
int a = 1;

if (n < 0)
    Console.WriteLine ("Введено не верное значение");
else
{
    int power = 3;
    for (int i = 1; i < n+1; i++)
    {
    Console.Write(Math.Pow(+ i, power) + " ");
    }
}
Console.WriteLine();