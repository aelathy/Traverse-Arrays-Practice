// Traverse Arrays Practice

// 1

// List<string> results = new List<string>();
// bool loop = true;
// while (loop)
// {
//     // Answers
//     Console.WriteLine("1. Yes");
//     Console.WriteLine("2. No");
//     Console.WriteLine("3. Maybe");
//     Console.WriteLine("4. Exit");
//     Console.Write("Please enter a number from 1-3 or type 4 to exit: ");
//     string response = Console.ReadLine();

//     if (response == "1")
//     {
//         results.Add("Yes");
//     }
//     else if (response == "2")
//     {
//         results.Add("No");
//     }
//     else if (response == "3")
//     {
//         results.Add("Maybe");
//     }
//     else if (response == "4")
//     {
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Not a valid response, please try again.");
//     }
// }

// int yesCount = 0;
// int noCount = 0;
// int maybeCount = 0;

// foreach (string result in results)
// {
//     if (result == "Yes")
//     {
//         yesCount++;
//     }
//     else if (result == "No")
//     {
//         noCount++;
//     }
//     else
//     {
//         maybeCount++;
//     }
// }

// Console.WriteLine(yesCount);
// Console.WriteLine(noCount);
// Console.WriteLine(maybeCount);

// 2
// List<int> ages = new List<int>() { 2, 2, 3, 19, 18 };

// int under18 = 0;
// int over18 = 0;

// foreach (int age in ages)
// {
//     if (age < 18)
//     {
//         under18++;
//     }
//     else if (age >= 18)
//     {
//         over18++;
//     }
// }

// Console.WriteLine(under18);
// Console.WriteLine(over18);

// 3
List<double> prices = new List<double>() { -20, 14, 0, 2.5, 1000, 2, 50, 20, 25, 90 };

//a
int under20 = 0;
int twentyTo49 = 0;
int over50 = 0;
foreach (int price in prices)
{
    if (price < 20)
    {
        under20++;
    }
    else if (price >= 20 && price < 50)
    {
        twentyTo49++;
    }
    else
    {
        over50++;
    }
}

Console.WriteLine(under20);
Console.WriteLine(twentyTo49);
Console.WriteLine(over50);

Console.WriteLine();

// a
for (int i = 0; i < prices.Count; i++)
{
    prices[i] += 2;
}

foreach (int price in prices)
{
    Console.WriteLine(price);
}

Console.WriteLine();

//b
for (int i = 0; i < prices.Count; i++)
{
    double percent = 1.05;
    prices[i] = prices[i] * percent;
}

foreach (int price in prices)
{
    Console.WriteLine(price);
}

Console.WriteLine();


//c
for (int i = 0; i < prices.Count; i++)
{
    double percent = 0.8;
    prices[i] = prices[i] * percent;
}

foreach (int price in prices)
{
    Console.WriteLine(price);
}

Console.WriteLine();