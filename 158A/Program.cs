var input = Console.ReadLine().Split();

int n = Int32.Parse(input[0]);
int m = Int32.Parse(input[1]);

var a = Console.ReadLine().Split();
int count = 0;

for (int i = 0; i < n; i++)
{
    if (Int32.Parse(a[i]) == 0) break;
    if (Int32.Parse(a[i]) >= Int32.Parse(a[m-1]))
    {
        count++;
    }
    else break;
}
Console.WriteLine(count);