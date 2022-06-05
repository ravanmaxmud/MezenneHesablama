string command1 ="/show-recent-currency-rates";
string command2 = "/find-currency-rate-by-code";
string command3 = "/calculate-amount-by-currecy";
Console.WriteLine(command1);
Console.WriteLine(command2); 
Console.WriteLine(command3);
Console.WriteLine();
while (true)
{
    string[] currencyValue = { "USD", "EUR","TRY","RUB"};
    float[] currencyvaluecost = { 1.7f, 1.8f, 0.1031f, 0.0271f };
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

            if (valueName == currencyValue[0])
            {
                Console.WriteLine($"{currencyvaluecost[0]}AZN");
            }
            if (valueName == currencyValue[1])
            {
                Console.WriteLine($"{currencyvaluecost[1]}AZN");
            }
            if (valueName ==currencyValue[2])
            {
                Console.WriteLine($"{currencyvaluecost[2]}AZN");
            }
            if (valueName ==currencyValue[3])
            {
                Console.WriteLine($"{currencyvaluecost[3]}AZN");
            }
            
        }
        //if (requierdName == command3)
        //{
        //    Console.Write("Calculate the Currency :");
        //    string valueName = Console.ReadLine();
        //    for (int i = 0; i <= 1000; i++)
        //    {
        //        if (i == currencyvaluecost[0])
        //        {
        //            Console.WriteLine(i*currencyValue.Length[0]);
        //        }
        //    }
             
        //}
        indexValue++;
    }   
}




















