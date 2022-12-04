Console.Clear();
int [] array = {11, 18, 53, 46, 53, 62, 76, 18};

int n= array.Length;
int find=18;
int index= 0;

while (index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //Чтобы при нахождении индекса
               //с искомым числом программа не продолжала искать дальше
    }
    index++; // index=index+1
}
