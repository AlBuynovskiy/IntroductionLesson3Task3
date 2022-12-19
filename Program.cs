// See https://aka.ms/new-console-template for more information
/*
Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N. int[] array =
*/


Console.Write("Введите кол-во чисел для вывода: ");
int N = int.Parse(Console.ReadLine());
 
Console.WriteLine("Число" + "\t" + "Квадрат");
for(int i = 1; i <= N; i++)

Console.WriteLine(i + "\t" + i*i);
Console.ReadLine();

  
   


  