Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int number1 = number[0];
int number2 = number[1];
int number3 = number[2];
int number4 = number[3];
int number5 = number[4];

if (number1 == number5 && number2 == number4)
{
    Console.WriteLine("Данное число палиндром!");
}
else
{
    Console.WriteLine("Даное число не является палиндромом");
}
