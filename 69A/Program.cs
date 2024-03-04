int cases = int.Parse(Console.ReadLine());

int xsum = 0, ysum=0, zsum=0;
for (int i = 0; i < cases; i++)
{
    var input = Console.ReadLine().Split();
    xsum += int.Parse(input[0]);
    ysum += int.Parse(input[1]);
    zsum += int.Parse(input[2]);
    
}
if (xsum == 0 && ysum==0 && zsum==0) Console.WriteLine("YES");
else Console.WriteLine("NO");