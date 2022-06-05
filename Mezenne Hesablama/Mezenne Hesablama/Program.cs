string command1 = "/show-recent-currency-rates";
string command2 = "/find-currency-rate-by-code";
string command3 = "/calculate-amount-by-currecy";
Console.WriteLine(command1);
Console.WriteLine(command2);
Console.WriteLine(command3);
string[] currencyValue = { "USD", "EUR", "TRY", "RUB" };
float[] currencyvaluecost = { 1.7f, 1.8f, 0.1031f, 0.0271f };
Console.WriteLine();
double number = 0;

while (true)
{
    int indexValue = 0;
    Console.Write($"Istediyinizi daxil edin:");
    string requierdName = Console.ReadLine();
    while (indexValue < currencyvaluecost.Length)
    {
        if (requierdName == command1)
        {
            Console.Write("AZN");
            Console.WriteLine($" {currencyvaluecost[indexValue]} = {currencyValue[indexValue]}");
        }
        if (requierdName == command2)
        {
            Console.Write("Choose the Currency :");
            string valueName = Console.ReadLine();
            int totalcurrencycounter = 0;
            if (valueName == currencyValue[0])
            {
                Console.WriteLine($"{currencyvaluecost[0]}AZN");
            }
            if (valueName == currencyValue[1])
            {
                Console.WriteLine($"{currencyvaluecost[1]}AZN");
            }
            if (valueName == currencyValue[2])
            {
                Console.WriteLine($"{currencyvaluecost[2]}AZN");
            }
            if (valueName == currencyValue[3])
            {
                Console.WriteLine($"{currencyvaluecost[3]}AZN");
            }
        }
        if (requierdName == command3)
        {
            Console.Write($"Enter amount : (AZN) "); double requiredAZN = Convert.ToDouble(Console.ReadLine());
            while (number <= 1000)
            {
                if (requiredAZN == number)
                {
                    Console.WriteLine(0.5882 * requiredAZN + " (USD)");
                    Console.WriteLine(36.9003 * requiredAZN + " (RUB)");
                    Console.WriteLine(9.6993 * requiredAZN + " (TRY)");
                    Console.WriteLine(0.55 * requiredAZN + "(eur)");
                }
                number++;
            }

        }  indexValue++;
    }
}