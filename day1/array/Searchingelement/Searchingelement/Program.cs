string[] names = { "one", "two", "three", "four", "five" };


Console.WriteLine("Enter from one to five to search in small letters");
string searchName = Console.ReadLine();


int index = -1;

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == searchName)
    {
        index = i;
        break;
    }
}


if (index != -1)
{
    Console.WriteLine($"Name '{searchName}' found at index {index}.");
}
else
{
    Console.WriteLine($"Name '{searchName}' not found in the array.");
}
