Console.WriteLine();
string[] sourseArray = {"a","25524555", "-56", "logi", "mine God", "dog", "62252", "+698524" };

Console.WriteLine($"Исходный массив: {'['+string.Join(" ,", sourseArray)+']'}");

void CutArray(string[] array)
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

