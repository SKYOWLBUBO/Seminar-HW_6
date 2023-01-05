//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    System.Console.Write("message");
    return int.Parse(Console.ReadLine());
}


System.Console.Write("Введите длинну массива > ");
string inStr = Console.ReadLine();
int v = Convert.ToInt32(inStr);

int[] numbers = new int[v];
 int summ = 0;
for(int i = 0; i < v ; i++)
{
    System.Console.WriteLine("Введите число");
    string point = Console.ReadLine();
    int a = Convert.ToInt32(point);
    numbers[i] = a;
    if(a > 0)
    {  
        summ++;
    }
    
}
System.Console.WriteLine(summ);


