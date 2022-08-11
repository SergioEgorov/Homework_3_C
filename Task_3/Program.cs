Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int result = 1; result <= N; result++)
{
    Console.WriteLine(Math.Pow(result,3));
}
