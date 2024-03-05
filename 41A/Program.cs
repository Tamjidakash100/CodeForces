string input1 = Console.ReadLine();
string input2 = Console.ReadLine();

int res = 1;

for (int i = 0; i<input1.Length; i++)
{
    if (input1[i] != input2[input2.Length-i-1])
    {
        res = 0; break;
    }
}
if (res == 0) Console.WriteLine("NO");
else Console.WriteLine("YES");