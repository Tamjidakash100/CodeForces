var input = Console.ReadLine().Split();

long n = Int64.Parse(input[0]);
long m = Int64.Parse(input[1]);
long a = Int64.Parse(input[2]);

long x = n / a; 
long y = m/a;
if (n % a != 0)    x++;

if (m % a != 0)    y++;
Console.WriteLine(x*y);