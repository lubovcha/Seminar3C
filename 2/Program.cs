/* Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).*/
System.Console.Write("Введите номер четверти: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1){ 
System.Console.WriteLine("Возможные координаты точек x > 0 && y >0"); 
}
else if (n == 2){ 
System.Console.WriteLine("Возможные координаты точек x < 0 && y > 0");   
}
else if (n == 3){ 
System.Console.WriteLine("Возможные координаты точек x < 0 && y < 0");   
}
else if (n == 4){ 
System.Console.WriteLine("Возможные координаты точек x > 0 && y < 0");   
}
else if (n >= 5){ 
System.Console.WriteLine("Введена неверная четверть");   
}