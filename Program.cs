// Код программы
string[] originalArray = {"print","hello","car","|:(","><"};
int sizeArray = CountElement(originalArray);
string[] finalArray = new string[sizeArray];
finalArray = ConvertArray(originalArray, sizeArray);
Console.Write(string.Join(", ", finalArray));