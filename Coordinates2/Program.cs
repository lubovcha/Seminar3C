/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 
AB = корень (xb-xa) в квадрате + (yb-ya) в квадрате                       */
System.Console.Write("Координатy X первой точки:");
int x1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Координатy Y первой точки:");
int y1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Координатy X второй точки:");
int x2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Координатy Y второй точки:");
int y2 = Convert.ToInt32(Console.ReadLine());
         
double result = Math.Sqrt(Math.Pow ((x2-x1),2) + Math.Pow((y2-y1),2)); /* AB = корень (xb-xa) в квадрате + (yb-ya) в квадрате  */
System.Console.WriteLine(result); /* Math.Sqrt() = корень; Math.Pow() - квадрат