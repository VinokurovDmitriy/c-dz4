// программа принимает на вход число А и число В и возводит число А в степень В
//3, 5 -> 243
//2, 4 -> 16

void printExponention(int A, int B){
    Console.Write($"{A}, {B} -> ");
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
    Console.WriteLine(result);
}

printExponention(3, 5);
printExponention(2, 4);
