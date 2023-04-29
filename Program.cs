Console.WriteLine ("Итоговая работа");

string[] array1 = new string[] {"1234", "1567", "2", "-2", "computer science"};
string[] array2 = new string[array1.Length];

    for (int i = 0; i < array1.Length; i++)
    {if (array1[i].Length <= 3)
    {
        Console.Write(array1[i] + " ");
    }
}
