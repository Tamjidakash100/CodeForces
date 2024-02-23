string input = Console.ReadLine();

string a = "";

for (int i = 0; i < input.Length; i++)
{
    if (!a.Contains(input[i])) a+= input[i];
}
if (a.Length % 2 == 0) Console.WriteLine("CHAT WITH HER!");
else Console.WriteLine("IGNORE HIM!");