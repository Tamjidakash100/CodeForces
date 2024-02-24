string input = Console.ReadLine();
input = input.ToLower();
for(int i=0; i<input.Length; i++)
{
    if (input[i] !=  'a' && input[i] != 'e' && input[i] != 'i' && input[i] != 'o' && input[i] != 'u' && input[i] != 'y')
    {
        Console.Write("." + input[i]);
    }
}
Console.WriteLine();