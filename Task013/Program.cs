/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
             или сообщает, что третьей цифры нет.*/       


Console.Write("Задайте любое положительное число: ");
string? myArray = Console.ReadLine();
int numA = Convert.ToInt32(myArray);
if (numA < 100)
{
    Console.Write("Третьей цифры нет.");
}
else
{
    Console.Write("Третья цифра этого числа: " + myArray[2]);
}