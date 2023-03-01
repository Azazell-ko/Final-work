/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше или равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] Action(string[] text) 
{
    int number = 0;
    for(int index = 0; index < text.Length; index++)
    {
        if(text[index].Length <= 3)
            number++;        
    }    
    string[] result = new string [number];
    for(int index1 = 0, index2 = 0; index1 < text.Length; index1++)
    {
        if(text[index1].Length <= 3)
            result[index2++] = text[index1];
    }    
    return result;
}


string[] Data = {"Программа", "нос", "строка", "007", "21", "лучше", "-234"};

Console.Write("[{0}] -> [{1}] ", string.Join(", ", Data), string.Join(", ", Action(Data)));