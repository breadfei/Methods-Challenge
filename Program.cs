// Create a method called ConvertMinuteToSeconds. This method will take in an int called minutes. This method will convert minutes to seconds. Once converted, return it as an int.

Console.WriteLine(ConvertMinuteToSeconds(3));

static int ConvertMinuteToSeconds(int minutes)
{
    int seconds = minutes * 60;
    return seconds;
}


// Create a method called ConvertPositive. It should take in an int and return it as a positive int. If the value is positive already or a 0, return it as is. 

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


// Create a method called ConvertNegative. It should take in an int and return it as a negative int. If the value is negative already or a 0, return it as is. 

static int ConvertNegative(int value)
{
    if (value > 0)
    {
        value *= -1;
    }
    return value;
}


// Create a method called AreaTriangle. This method will take in a double called height and a double called length. Return the area as a double.

Console.WriteLine(AreaTriangle(4,4));

static double AreaTriangle(double height, double length)
{
    double area = height * length * 0.5;
    return area;
}


// Create a method called IsEnoughMoney. This method will take in 2 doubles, cost and payment. If the payment is equal or greater than the cost, return true. Otherwise return false.

Console.WriteLine(IsEnoughMoney(99,99));
Console.WriteLine(IsEnoughMoney(7,3));
Console.WriteLine(IsEnoughMoney(6,9));

static bool IsEnoughMoney(double cost, double payment)
{
    return payment >= cost;
}


// Create a method called GetSalary. This method will take in a string called job. It will return that job’s salary as a double.

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


// Create a method called CombineWords. This will take in 3 separate strings. This will return the 3 strings as 1 string seperated by a ,

Console.WriteLine(CombineWords("Apple", "Orange", "Banana"));

static string CombineWords(string word1, string word2, string word3)
{
    return $"{word1},{word2},{word3}";
}