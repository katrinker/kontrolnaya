/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.WriteLine("Введите количество слов которые нужно ввести");
int n = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine("Введите слова");

string[] array1 = new string[n];
for(int i = 0; i < array1.Length; i++)
{
   array1[i] = Console.ReadLine()!;
}

string[] array2 = new string[array1.Length];

NewArray(array1, array2);
PrintArray(array2);

void NewArray (string[] array1, string[] array2)
{
 int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


