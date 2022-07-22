/*  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""*/

string recursion(int m, int n)
{
    if(n == m)
        return m.ToString();
    else
        return m + ", " + recursion(m+1,n) ;
}
Console.WriteLine("введите число n");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число m");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"{recursion(m,n)} ");
