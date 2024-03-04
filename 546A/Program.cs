var input = Console.ReadLine().Split();

int k = int.Parse(input[0]);
int n = int.Parse(input[1]);
int w = int.Parse(input[2]);

int m = 0;
for (int i = 1; i <= w; i++)
{
    m += k* i;
}
if (m-n < 0) m = n;

Console.WriteLine(m-n);