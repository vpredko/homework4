int Step (int a, int b)
{
    int result = 1;
    for (int i=1; i<=b; i++)
        result = result*a;
        return result;
}
Console.WriteLine ("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите степень");
int B = Convert.ToInt32(Console.ReadLine());
int res = Step(A,B);
Console.WriteLine ($"{A}, {B} -> {res}");

