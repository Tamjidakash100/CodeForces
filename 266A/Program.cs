Console.ReadLine();
string input = Console.ReadLine();
int count = 0;
char prev = input[0];
for(int i = 1; i < input.Length; i++)
{
    if (prev == input[i]) count++;
    else prev = input[i];
}
Console.WriteLine(count);