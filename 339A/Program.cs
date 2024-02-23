var input = Console.ReadLine().Split("+");

int[] ints = new int[input.Length];

for (int i = 0; i < ints.Length; i++)
{
    ints[i] = int.Parse(input[i]);
}
Array.Sort(ints);
for (int i = 0; i<ints.Length; i++)
{
    if (i == ints.Length - 1)
    {
        Console.WriteLine(ints[i]);
        break;
    }
    Console.Write(ints[i]+"+");
}