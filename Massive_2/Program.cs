void FillArray(int[] collection)
//Если пременная не возвращает значение функции - Void-метод
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
    collection[index] = new Random().Next(1, 10);
    index++;    
    }
}

void PrintArray(int[] col1)
{
    int count = col1.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col1[position]);
        position++;
    }
}



int[] array = new int[10]; // создать новый массив с 10 элементами
                            // по умолчанию будет наполнен нулями

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; 
    //если искомого элемента нет в массиве - выведется ind = -1
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;  
}

FillArray(array); //метод заполнил массив
PrintArray(array); //метод распечатал массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

