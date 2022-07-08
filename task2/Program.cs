Console.WriteLine ("Введите число");
int number = Convert.ToInt32 (Console.ReadLine());
Console.Write(number + "->");
int sum = 0;
while (number>0)
{
    sum = sum + (number % 10);
    number = number/10;
}
Console.WriteLine(sum);

