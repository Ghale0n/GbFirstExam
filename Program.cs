// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, чья длина не превышает 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, или задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] only3Symbols(string[] array)
{   
    string stringResult = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            stringResult = stringResult + array[i] + " ";
        }
    }
    string[] finalArr = stringResult.Split(" ");
    return finalArr;
}
