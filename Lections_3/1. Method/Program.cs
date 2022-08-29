// метод 1
// void Method_1()
// {
//     Console.WriteLine("Автор: Anton Baranov");
// }
// Method_1();

//________________________________________________________________________________

// метод 2
// void Method_2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method_2("Hello, it's me");

//________________________________________________________________________________

// void Method_2(int count ,string msg)
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method_2(msg: "Hello, it's me", count: 8);

//________________________________________________________________________________

// метод 3

// int Method_3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method_3();
// Console.WriteLine(year);

//________________________________________________________________________________

// метод 3

// string Method_4(int count, char c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }

// string res = Method_4(count: 10000, c: '\u006A');
// Console.WriteLine(res);

//________________________________________________________________________________

// void For(int count, char c)
// {   
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + c;
//     }
//     Console.WriteLine(result);
// }
// For(count: 10000, c: '\u006A');
//________________________________________________________________________________

// void tt()
// {   
//     for(int i = 2; i <= 10; i++)
//     {
//         for(int j = 2; j <= 10; j++)
//         {
//             Console.WriteLine($"{i} x {j} = {i * j}");
//         }
//     Console.WriteLine();
//     }
// }

// tt();

// Работа с текстом
// Дан текст. В тексте все пробелы нужно заменить черточками,
// маленькие буквы "к" заменить на большие буквы "К",
// а большие "С" заменить на маленькие "с"



// string text = " — Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = qwerty
//            012345
// s[3] - r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newtext = Replace(text, ' ', '_' );
// Console.WriteLine(newtext);

// Console.WriteLine(newtext);
// newtext = Replace(text, 'к', 'К' );
// Console.WriteLine(newtext);
// newtext = Replace(text, 'С', 'с' );


int [] arr = {1, 3, 5, 3, 6, 6, 3, 2, 35, 6, 7};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

