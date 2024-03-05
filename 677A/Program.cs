var input = Console.ReadLine().Split();
var input1 = Console.ReadLine().Split();

int h = int.Parse(input[1]);
int rw = 0;

for (int i = 0; i < input1.Length; i++)
{
    if (int.Parse(input1[i]) > h) rw += 2;
    else rw++;
}
Console.WriteLine(rw);