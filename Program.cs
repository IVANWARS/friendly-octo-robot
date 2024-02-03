int[] array = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
int numberForSearch = 44;
bool isFound = false;

for (int i = 0; i < array.Length; i++)
{
    if (numberForSearch == array[i])
    {
        isFound = true;
        //Console.WriteLine("да");
        break;
    }

}
if (isFound)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}