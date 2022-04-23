int[] array5 = new int[5];
int[] array3 = new int[3];
int[] arrayRandom = new int[8];
int[] arrayRandom2 = new int[4];

int getRandom()  //возвращает случайное число от 1 до 9

{
    return new Random().Next(1, 10);
}

int getReadConsole()  //возвращает число введенное с клавиатуры
{
    return Convert.ToInt32(Console.ReadLine());
}

void fillArray(int[] array, bool random) //заполняет массив значениями
{
    for (int i = 0; i < array.Length; i++)
    {
        int current;
        if (random) current = getRandom();
        else current = getReadConsole();
        array[i] = current;
    }
}
void printArray(int[] array) //печатает массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//Заполнение массивов с клавиатуры и печать массива
Console.WriteLine("Введите последовательно цифры 1, 2, 5, 7, 19");
fillArray(array5, false);
printArray(array5);
Console.WriteLine("Введите последовательно цифры 6, 1, 33");
fillArray(array3, false);
printArray(array3);

//Заполнение массива сгенерированными числами
fillArray(arrayRandom, true);
fillArray(arrayRandom2, true);
Console.WriteLine("Печать массивов с элементами заполенными генератором случайных чисел");
printArray(arrayRandom);
printArray(arrayRandom2);


