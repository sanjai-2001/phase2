
//double num1, num2;
//   int res;

//num1 = Convert.ToDouble(Console.ReadLine());
//num2 = Convert.ToDouble(Console.ReadLine());

//res = (int)(num1 + num2);

//Console.WriteLine(res);

//Amstrong Number

//int num, sum = 0;

//num = Convert.ToInt32(Console.ReadLine());
//int temp = num;
//while (num > 0)
//{
//    int rem = num % 10;
//    sum += rem * rem * rem;
//    num /= 10;
//}
//if (sum == temp)
//{
//    Console.WriteLine("Amstrong Number");
//}
//else
//{
//    Console.WriteLine("Not an Amstrong Number");
//}

//Perfect Number

int num, sum = 0;

num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < num; i++)
{
    if (num % i == 0)
    {
        sum = sum + i;
    }
}
if (sum == num)
{
    Console.WriteLine("Perfect Number");
}
else
{
    Console.WriteLine("Not Perfect Number");
}

//Perfect number between 20 and 40

int num1, num2;
Console.WriteLine("Enter the Start value: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the End value: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Prime numbers are: ");
for (int i = num1; i <= num2; i++)
{
    int point = 0;
    for (int j = 2; j <= (i / 2); j++)
    {
        if (i % j == 0)
        {
            point = 1;
        }
    }
    if (point == 0)
    {
        Console.WriteLine(i);
    }
}