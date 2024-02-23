string input = Console.ReadLine();

string a = input[0].ToString();
a = a.ToUpper()+ input.Substring(1, input.Length-1); 
Console.WriteLine(a);
