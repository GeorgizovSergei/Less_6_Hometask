// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Какое количество чисел вы хотите ввести: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[number];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

}
void WriteLine(int[] massive)
{

    Console.Write("Сформирован массив [ ");
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write(massive[i] + " ");
    }
    Console.Write("]. ");



}

int PositiveNumber(int[] array)
{
    int countPosNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            countPosNum++;
        }
    }
    return countPosNum;
}

FillArray(massive);
WriteLine(massive);
int result = PositiveNumber(massive);
Console.WriteLine($"Пользователь ввел {result} чисел больше ноля.");