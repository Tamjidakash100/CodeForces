int input = Int32.Parse(Console.ReadLine());
int count = 0;
string a;
for (int i = 0; i<input; i++)
{
    a = Console.ReadLine();
    if (a == "X++" || a == "++X")
    {
        count++;
    }
    else count--;
}
Console.WriteLine(count);