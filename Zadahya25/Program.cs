Console.Clear();
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int n = a;
for(int i = 1; i < b; i++)
{    
    n = n * a;   
}
Console.Write(n);



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// НЕ ИСПОЛЬЗОВАТЬ MATH.POW
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16