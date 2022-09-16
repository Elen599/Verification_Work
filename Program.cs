// Функция подсчета подходящих элементов
int CountElement (string[] array)
{
    int size = 0, temp = 0;
    string box = "";
    for (int i = 0; i < array.Length; i++)
    {
        box = array[i];
        temp = box.Length;
        if (temp < 4)
            size ++;
    }
    return size;
}

// Код программы
string[] originalArray = {"print","hello","car","|:(","><"};
int sizeArray = CountElement(originalArray);
string[] finalArray = new string[sizeArray];
finalArray = ConvertArray(originalArray, sizeArray);
Console.Write(string.Join(", ", finalArray));