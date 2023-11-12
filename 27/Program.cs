// // Задача 27: Напишите программу, которая принимает на вход число 
// // и выдаёт сумму цифр в числе.



int Prompt (string str) 
 {
     Console.WriteLine(str);
     int number = Convert.ToInt32(Console.ReadLine());
     return number;
 }

 int Length (int number)
 {
     int ind = 0;
     while (number > 0)
     {
         number = number / 10;
         ind++;
     }
     return ind;
 }

 void sum (int b, int len)

 {
     int sum = 0;
     for (int i = 1; i <= len; i++)
     {
         sum += b % 10;
         b = b / 10; 
     }
     Console.WriteLine($"Сумма цифр в числе A равна: " + sum);
 }

int a = Prompt("Введите число А: ");
int len = Length(a);
sum(a, len);
 

