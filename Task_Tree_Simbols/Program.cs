Console.WriteLine();
string[] sourseArray = {"a","25524555", "-56", "login", "mine God", "dogg", "622", "+698524" };

Console.WriteLine($"Исходный массив: {'['+string.Join(" ,", sourseArray)+']'}"); // Вывод исходного массива на экран

void CutArray(string[] array) // Метод, который будет отсекать элементы с длинной более 3-х символов
{
    string[] cutArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            cutArray[i] = array[i];
        }
    } 
    Console.Write($"Сокращенный массив: {'['+string.Join(" ", cutArray)+']'}"); 
}
CutArray(sourseArray);

