/*Напишите программу, которая принимает на вход координаты точки (Х и Y), причем X не равно 0 и Y не равно 0
и выдает номер четверти плоскости, в которой находится эта точка.*/
System.Console.Write("Введите Х: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y >0){ /*если x больше 0  И  y больше 0 */
System.Console.WriteLine(1);
}
else if (x < 0 && y > 0){ /*если x меньше 0  И  y больше 0 */
System.Console.WriteLine(2);   
}
else if (x < 0 && y < 0){ /*если x меньше 0  И  y меньше 0 */
System.Console.WriteLine(3);   
}
else if (x > 0 && y < 0){ /*если x больше 0  И  y меньше 0 */
System.Console.WriteLine(4);   
}
