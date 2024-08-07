Console.WriteLine(ConvertMinuteToSeconds(3));

static int ConvertMinuteToSeconds(int minutes)
{
    int seconds = minutes * 60;
    return seconds;
}

Console.WriteLine(ConvertPositive(77));
Console.WriteLine(ConvertPositive(-57));
Console.WriteLine(ConvertPositive(0));

Console.WriteLine(ConvertNegative(42));
Console.WriteLine(ConvertNegative(-18));
Console.WriteLine(ConvertNegative(0));

static int ConvertPositive(int value)
{
    if (value < 0)
    {
        value *= -1;
    }
    return value;
}

static int ConvertNegative(int value)
{
    if (value > 0)
    {
        value *= -1;
    }
    return value;
}

Console.WriteLine(AreaTriangle(4,4));

static double AreaTriangle(double height, double length)
{
    double area = height * length * 0.5;
    return area;
}

Console.WriteLine(IsEnoughMoney(99,99));
Console.WriteLine(IsEnoughMoney(7,3));
Console.WriteLine(IsEnoughMoney(6,9));

static bool IsEnoughMoney(double cost, double payment)
{
    return payment >= cost;
}

Console.WriteLine(GetSalary("Janitor"));
Console.WriteLine(GetSalary("CEO"));
Console.WriteLine(GetSalary("Developer"));
Console.WriteLine(GetSalary("Programmer"));

static double GetSalary(string job)
{
    //if (job == "Janitor")
    //{
    //    return 50000;
    //}
    //else if (job == "Developer")
    //{
    //    return 70000;
    //}
    //else if (job == "CEO")
    //{
    //    return 100000;
    //}
    //else
    //{
    //    return 0;
    //}

    switch (job)
    {
        case "Janitor":
            return 50000;
        case "Developer":
            return 70000;
        case "CEO":
            return 100000;
        default:
            return 0;
    }
}

Console.WriteLine(CombineWords("Apple", "Orange", "Banana"));

static string CombineWords(string word1, string word2, string word3)
{
    return $"{word1},{word2},{word3}";
}