int[] array = {15,2,72,33,45,15,6,72,8,91};

int n = array.Length;
int find = 72;

int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index ++;
}
