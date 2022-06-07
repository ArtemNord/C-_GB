int[] array = {1,2,34,54,23,123,54,23};

int n = array.Length;
int find = 23;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}