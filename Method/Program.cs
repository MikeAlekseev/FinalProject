//блаблабла

string[] arr1 = new string[5] {"54", "229", "hello", "world", "rus"};
string[] arr2 = new string[arr1.Length];
void SecondArray(string[] massive1, string[] massive2)
{
    int count = 0;
    for (int i = 0; i < massive1.Length; i++)
    {
    if(massive1[i].Length <= 3)
        {
        massive2[count] = massive1[i];
        count++;
        }
    }
}
void PrintArray(string[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"{massive[i]} ");
    }
    Console.WriteLine();
}
SecondArray(arr1, arr2);
PrintArray(arr2);
