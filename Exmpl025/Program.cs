// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Задача 25: Возвести заданное число в заданную степень");
Console.Write("Введите число, которое будем возводить в степень:  ");
int A = Convert.ToInt32(Console.ReadLine());
int NachalnA = A;
Console.Write("Введите значение степени, в которую будем возводить заданное Вами число:  ");
int B = Convert.ToInt32(Console.ReadLine());
//double result = Math.Pow(A, B);
for (int i=1; i<B;i++)
{
    A = A * NachalnA;
    //Console.WriteLine($"{A}");
}
Console.WriteLine($"Возведем {NachalnA} в степень {B}, получаем = {A}");
// Console.WriteLine($"Возведем {A} в степень {B}, получаем = {result}");
