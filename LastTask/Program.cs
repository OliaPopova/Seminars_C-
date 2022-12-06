//Финальное задание курса

string[] myArray1 = new string[6] {"hello","!","67543", "world", "22", "foo"};

string[] ElementsSelection(string[] myArray1){
    int count = 0;
    for (int i = 0; i < myArray1.Length; i++)
    {
    if(myArray1[i].Length <= 3)
        {
        count++;
        }
    }
    string[] myArray2 = new string[count];
    int j = 0;
    for (int i = 0; i < myArray1.Length; i++)
    {
    if(myArray1[i].Length <= 3)
        {
        myArray2[j] = myArray1[i];
        j++;
        }
    }
    return myArray2;
}

void PrintArray(string[] array){
    Console.Write("[ ");
     for (int i = 0; i < array.Length; i++)
    {   
        Console.Write($"\"{array[i]}\" ");
    }
    Console.Write(" ]");
}
string[] myArrayFinal=ElementsSelection(myArray1);
PrintArray(myArray1);
 Console.Write($"-> ");
PrintArray(myArrayFinal);