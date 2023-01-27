/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> O
*/

string[] Array = new string [] {"hello", "2", "world", ":-)"};
int count = 0;
    for(int i = 0; i < Array.Length; i++ )
    {
        if(Array[i].Length <= 3) count++;
    }
string[] Array002 = new string [count];


void PrintArray(string[] collection)
{
    int Length = collection.Length;
    int index = 0;  
     while(index < Length)
    {
        Console.Write($"\"{collection[index]}\" ");
        index++;
    }
}

void CheckingArrayValues(string[] Array, string[] Array002)
{
    int i002 = 0;
    for(int i = 0; i < Array.Length; i++ )
    {
        if(Array[i].Length <= 3)
        {
            Array002[i002] = Array[i];
            i002++;
        }
    }
    PrintArray(Array002);
}
if(count == 0) Console.WriteLine(0);
else CheckingArrayValues(Array, Array002);
