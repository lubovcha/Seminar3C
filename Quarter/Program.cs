/* Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
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
else{ 
System.Console.WriteLine("Введена неверная четверть");   
} */

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine()); /* переменная, которая отвечает за переменную четверть*/

switch (quarter){ /*switch взаимо земняемая конструкция с if, пишется один раз */
case 1: /* тоже самое, что и if (quarter == 1)*/
    System.Console.WriteLine("Возможные координаты точек x > 0 && y >0");
    break; // что бы не провалиться в следующий кейс
case 2: 
    System.Console.WriteLine("Возможные координаты точек x < 0 && y > 0");
    break; 
case 3: 
    System.Console.WriteLine("Возможные координаты точек x < 0 && y < 0");
    break; 
case 4: 
    System.Console.WriteLine("Возможные координаты точек x > 0 && y < 0");
    break;
default: /* аналог else */
     System.Console.WriteLine("Введена неверная четверть");
     break;  
}

/*if (quarter == 1){
    System.Console.WriteLine("Возможные координаты точек x > 0 && y >0");
}
else if (quarter == 2){
    System.Console.WriteLine("Возможные координаты точек x < 0 && y > 0");
}    
else if (quarter == 3){
    System.Console.WriteLine("Возможные координаты точек x < 0 && y < 0");;
} 
else if (quarter == 4){
    System.Console.WriteLine("Возможные координаты точек x > 0 && y < 0");
} 
else{ 
System.Console.WriteLine("Введена неверная четверть");   
} */
