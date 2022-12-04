void FillArray(int[] collection) // метод для заполнения массива рандомными числами
{
    int size = collection.Length;
    int index=0;
    while (index<size)
    {
        collection[index] = new Random().Next(1,10);
        index++;

    }
}

void PrintArray(int[] col) // Метод для печати массива
{
    int count = col.Length;
    int position =0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index00f(int [] collection, int find)
{
    int count = collection.Length;
    int index=0;
    int position=-1; //для определения того что элемент не найден

    while (index<count)
    {
        if (collection[index]==find)
        {
            position=index;
            break; //для завершения поиска position
        }
       index++; 
    }
    return position;
}




int [] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos=Index00f(array, 44);
Console.WriteLine(pos);

//метод Void подразумевает что он ничего не возвращает
