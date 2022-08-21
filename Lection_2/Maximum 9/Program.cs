int a1 = 154;
int a2 = 21;
int a3 = 39;
int a4 = 12;
int a5 = 23;
int a6 = 33;
int a7 = 13;
int a8 = 23;
int a9 = 33;

int max = a1;
// if(a2 > max) max = a2;
// if(a3 > max) max = a3;
// if(a4 > max) max = a4;
// if(a5 > max) max = a5;
// if(a6 > max) max = a6;
// if(a7 > max) max = a7;
// if(a8 > max) max = a8;
// if(a9 > max) max = a9;

// Console.WriteLine($"Самое большое число равно: {max}")

int Max(int number_1, int number_2, int number_3)
{
    int result = number_1;
    if(number_1 > result) result = number_2;
    if(number_2 > result) result = number_2;
    if(number_3 > result) result = number_3;
    return result;
}

// int max_1 = Max(a1, a2, a3);
// int max_2 = Max(a4, a5, a6);
// int max_3 = Max(a7, a8, a9);

max = Max(
    Max(a1, a2, a3),
    Max(a4, a5, a6),
    Max(a7, a8, a9));


Console.WriteLine($"Самое большое число равно: {max}");
