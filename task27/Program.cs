// Программа принимает на вход число и выводит на экран сумму цифр числа
//452 -> 11
//82 -> 10
//9012 ->12

void printNumSum(int num){
    int result = 0;
    Console.Write($"{num} -> ");
    while(num != 0){
        result += num%10;
        num /= 10;
    }
    Console.WriteLine(result);
}

printNumSum(452);
printNumSum(82);
printNumSum(9012);

