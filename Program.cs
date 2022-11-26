// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, чья длина не превышает 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, или задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] only3Symbols(string[] userArr)
{   
    string stringResult = String.Empty;
    for (int i = 0; i < userArr.Length; i++)
    {
        if (userArr[i].Length <= 3)
        {
            stringResult = stringResult + userArr[i] + ",";
        }
    }
    string[] finalArr = stringResult.Split(",");
    return finalArr;
}

Console.Clear();
Console.WriteLine("Задайте элементы массива разной длины через запятую: ");
string userArr = (Console.ReadLine()!);
string[] finalArr = userArr.Split(",");

Console.WriteLine($"Был массив такой: [{userArr}], а стал такой: [{string.Join(",", only3Symbols(finalArr))}]");