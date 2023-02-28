// Программа которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символам.

//ввод числа
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод.");
        }
    }

    return result;
}

///инициализирую массив рандомных строк из слов и чисел
string[] InitArray(int dimension)
{
    string[] arr = new string[dimension];
    Random rnd = new Random();
    int randValue;
    int randTimes;
    int randIndicator;
    char letter;
    string str = "";

    for (int i = 0; i < dimension; i++)
    {
        randIndicator = rnd.Next(0, 2);
        if (randIndicator == 1)
        {
            randTimes = rnd.Next(0, 5);
            for (int j = 0; j < randTimes; j++)
            {
                randValue = rnd.Next(0, 26);
                letter = Convert.ToChar(randValue + 65);
                str = str + letter;
            }
            arr[i] = Convert.ToString(str);
        }
        else
        {
            randValue = rnd.Next(-100000, 100000);
            arr[i] = Convert.ToString(randValue);
        }

    }

    return arr;
}

//печатаю массив
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }

    Console.WriteLine();
}

///создание нового массива строк длиной до 4 символов
string[] SmalArr(string[] arr)
{

    string[] newArr;
    int len = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) len++;

    }
    newArr = new string[len];
    len = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <= 3)
        {
            newArr[len] = arr[j];
            len++;
        }

    }
    return newArr;
}



int number = GetNumber("введите длину массива");
System.Console.WriteLine();

string[] array = InitArray(number);
Console.WriteLine("Сгенерированный массив");
PrintArray(array);
System.Console.WriteLine();
Console.WriteLine("состовляющие массива");
Console.WriteLine(string.Join(", ", array));

System.Console.WriteLine();
string[] newArray = SmalArr(array);
Console.WriteLine("массив из строк длина которых меньше или равно 3");
PrintArray(newArray);
System.Console.WriteLine();
Console.WriteLine("состовляющие массива");
Console.WriteLine(string.Join(", ", newArray));

