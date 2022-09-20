string[] massive1 = new string[5] {"55555", "world", "-:9", "vvvkkkd", "xxx"};
string[] massive2 = new string[massive1.Length];

void SecondMassive(string[] massive1, string[] massive2)
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
void PrintMassive(string[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"{massive[i]} ");
    }
    Console.WriteLine();
}
SecondMassive(massive1, massive2);
Console.WriteLine("Массив из элементов начального массива, длина которых меньше либо равна трем символам, это");
PrintMassive(massive2);
