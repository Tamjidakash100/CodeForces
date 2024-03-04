string input = Console.ReadLine();
int zero = 0, one = 0;

for(int i=0; i<input.Length; i++)
{
    if (zero == 7 || one == 7)
    {
        break;
    }
    if (input[i] == '0')
    {
        zero++; one = 0;
    }
    else
    {
        one++; zero = 0;
    }
}
if (zero == 7 || one == 7) Console.WriteLine("YES");
else Console.WriteLine("NO");

