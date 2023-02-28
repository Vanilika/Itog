// 4. Написать программу решающую поставленую задачу:
// из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.

string[] existingarray = new string[] {"один", "два", "три", "four", "five", "6", "seven", "8", "nine"};
string[] result = new string[existingarray.Length];
int size = 3;
int count = 0;

for (int i = 0; i < existingarray.Length; i++)
{
    if(existingarray[i].Length <= size)
    {
        result[count] = existingarray[i];
        Console.Write($"{result[count]} ");
        count++;
    }
}