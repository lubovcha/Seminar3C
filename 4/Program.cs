/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4   */

System.Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
/* double a = 1;

while (a <= n){ 
    System.Console.WriteLine(Math.Pow(a,2)); /* или System.Console.WriteLine(a*a) 
    a++; 
} 
*/
for (int a = 1; a <= n; a++){ /* for = аналог while */
System.Console.WriteLine(Math.Pow(a,2));
}  