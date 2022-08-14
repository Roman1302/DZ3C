/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
Console.WriteLine("Программа проверки пятизначного числа на палиндромность");
Console.WriteLine("Введите пятизначное число: ");

string number = Console.ReadLine()!;
int numberCheck = int.Parse(number!);

Console.Write("\n");
if (numberCheck < 10000 || numberCheck > 99999)
{
    Console.WriteLine("Неверно задано число");
    return;
}

 else if (number![0] == number[4] && number[1] == number[3])

    Console.WriteLine("ДА");

else

    Console.WriteLine("Нет");
