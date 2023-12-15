// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// Массив входных данных
using System.Globalization;

string[] startArray = new string[5] {"array", "for", "final", "job", "123"};
// Массив выходных данных (длина равна startArray)
string[] endArray = new string[startArray.Length];
int j = 0;

// Функция для поиска решения поставленной задачи
void SearchResult(string[] startArray, string[] endArray)
{
    
    for (int i = 0; i < startArray.Length; i++)
    {   
        if (startArray[i].Length <= 3)
        {
            endArray[j] = startArray[i];
            j++;
        }
    }
}

// Функция для вывода на экран решения поставленной задачи
void PrintResult(string[] startArray)
{
    Console.WriteLine("Result: ");
    for (int i = 0; i < endArray.Length; i++)
    {
        Console.WriteLine(endArray[i]);
    }

}


SearchResult(startArray, endArray);
PrintResult(startArray);