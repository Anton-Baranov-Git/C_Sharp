int[] array = { 4, 53, 2, 4, 5, 7, 8, 4, 2, 2, 45, 56 };
int n = array.Length;
int find = 4;
int i = 0;
while (i < n)
{
    if(array[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    i++;
}
