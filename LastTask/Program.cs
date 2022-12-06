//Финальное задание курса

string[] myArray1 = new string[6] {"hello","!","67543", "world", "22", "foo"};
string[] myArray2 = new string[myArray1.Length];


void ElementsSelection(string[] myArray1, string[] myArray2){
    int count = 0;
    for (int i = 0; i < myArray1.Length; i++)
    {
    if(myArray1[i].Length <= 3)
        {
        myArray2[count] = myArray1[i];
        count++;
        }
    }
}

void PrintArray(){}

