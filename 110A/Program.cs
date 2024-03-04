string input = Console.ReadLine();
int count = 0;
for(int i=0; i<input.Length; i++)
{
    if (input[i] =='4' || input[i] =='7') count++;
}

string n = count.ToString();
for (int i = 0; i < n.Length; i++)
{
    if (n[i] != '4' && n[i] != '7')
    {
        Console.WriteLine("NO");
        break;
    }
    if (i == n.Length - 1)
    {
        Console.WriteLine("YES");
    }
}