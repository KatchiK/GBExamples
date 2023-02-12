// See https://aka.ms/new-console-template for more information

Console.Clear();

int[] array={ 10,1923,14,6,1234,745,24,21262,1345};

int n = array.Length;

int find = 746;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    
    index++;
}