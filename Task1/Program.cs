Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int[] digits = new int[5];
int i = 1;
while (i != 6)
{
    digits[i-1] = number % 10;
    number /= 10;
    i++;
}
if (digits[0] == digits[4] && digits[1] == digits[3])
{
    Console.WriteLine("Ваше число палиндром");
}
else
{
    Console.WriteLine("Ваше число не палиндром");
}