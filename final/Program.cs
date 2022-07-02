string[] arr = { "Uzbekistan", "Pen", "999", "01", "PC", "Windows", "Door" };
int count = 0;
int count2 = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3) count++;
}
string[] new_arr = new string[count];
for (int j = 0; j < arr.Length; j++)
{
    if (arr[j].Length <= 3) { new_arr[count2] = arr[j]; count2++; }
}