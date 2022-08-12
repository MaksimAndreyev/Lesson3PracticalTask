Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <= N)
{
    if (i == N)
    {
        Console.WriteLine(i*i*i);
        break;
    }
    Console.Write(i*i*i + ", ");
    i++;
}