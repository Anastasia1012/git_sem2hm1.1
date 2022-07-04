/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("input the programm which inputs three-digit numbers and outputs the second");
int numb = Convert.ToInt32(Console.ReadLine());
numb =(numb / 10)%10;
Console.WriteLine(numb);

