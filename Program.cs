//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

int elementLen = 3;
string[] array = { "1234", "1567", "-2", "computer science" };
int size = CountElements(array);

int CountElements(string[] array)
{
    int CountElement = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elementLen) CountElement++;
    }
    return CountElement;
}
