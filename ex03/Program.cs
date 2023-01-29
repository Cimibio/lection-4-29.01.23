// факториал через рекурсию
/*
double Factorial (int n)
{
    if (n == 1) return 1; // 1!=1
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/


//числа Фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int fib(int n)
{
    if (n == 1 || n == 2) return 1;
    else return fib(n-1) + fib(n - 2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i} {fib(i)}");
}