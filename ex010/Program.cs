int[] array = {14,2,3,14,5,6,7,8};

int n = array.Length;
int find = 14;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}