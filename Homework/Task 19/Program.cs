/* 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом 
(число, одинаково читающееся в обоих направлениях)

14212 -> нет

12821 -> да

23432 -> да
*/

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine()); //задаем переменную anyNumber
string anyNumberText = Convert.ToString(anyNumber); // переводим в ряд чисел

if (anyNumberText[0] == anyNumberText[4] && anyNumberText[1] == anyNumberText[3]) //тут не ставятся {} внутри совместно с []}
    Console.WriteLine("Число является палиндромом"); 
else{
    Console.WriteLine("Число не является палиндромом");
}