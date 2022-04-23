// Программа принимает на вход число и выводит на экран сумму цифр числа
//452 -> 11
//82 -> 10
//9012 ->12

int num1 = 452;
int num2 = 82;
int num3 = 9012;

void printNumSum(int num){
    int result = 0;
    Console.Write($"{num} -> ");
    while(num != 0){
        result += num%10;
        num /= 10;
    }
    Console.WriteLine(result);
}

printNumSum(num1);
printNumSum(num2);
printNumSum(num3);
