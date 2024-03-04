var input = Console.ReadLine();
int uCounter = 0, lCounter = 0;
for (int i = 0; i<input.Length; i++)
{
    if (Char.IsUpper(input[i])) uCounter++;
    if (Char.IsLower(input[i])) lCounter++;
}
if (uCounter>lCounter) input = input.ToUpper();
else input =  input.ToLower();

Console.WriteLine(input);