int[] array = {3, 4, 54, 33, 3221, 2222, 4, 55, 444}

int max = array[0];
array[0] = 12;


int Max(int number_1, int number_2, int number_3)
{
    int result = number_1;
    if(number_1 > result) result = number_2;
    if(number_2 > result) result = number_2;
    if(number_3 > result) result = number_3;
    return result;
}
Console.WriteLine(array[0]);

max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine($"Самое большое число равно: {max}");
