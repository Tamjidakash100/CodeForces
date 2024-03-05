string num = Console.ReadLine();
string input = Console.ReadLine();

int dCount =0, aCount = 0;

for (int i = 0; i<input.Length; i++)
{
    if (input[i] == 'A') aCount++;
    if (input[i] == 'D') dCount++;
}
if (dCount > aCount) Console.WriteLine("Danik");
else if (aCount > dCount) Console.WriteLine("Anton");
else Console.WriteLine("Friendship");