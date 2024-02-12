int number = 29;

if (number >= 10 && number <= 99)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit >= secondDigit)
    {
        Console.WriteLine($"В числе {number} цифра {firstDigit} является наибольшей");
    }
    else
    {
        Console.WriteLine($"В числе {number} цифра {secondDigit} является наибольшей");
    }
}
else
{
    Console.WriteLine($"Число {number} не соответсвует требования (целое число из отрезка [10, 99])");
}