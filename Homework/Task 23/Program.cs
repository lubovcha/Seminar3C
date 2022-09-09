/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/

System.Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());

for (int a = 1; a <= n; a++){ /* for = аналог while */
System.Console.WriteLine(Math.Pow(a,3));
} 