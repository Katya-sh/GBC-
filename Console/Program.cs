void rearray2 (string[] array1, string[] array2)
{
int count = 0;
for (int i = 0; i < array1.Length; i++)
{
if (array1[i].Length <= 3)
{
array2[count] = array1[i];
count++;
}
}
}
string [] array1 = new string [4] {"12", "err", "world", ":-)"};
string [] array2 = new string [array1.Length];

for (int i = 0; i < array2.Length; i++)
{
Console.Write($" {array2[i]} ");
}