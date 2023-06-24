int a = int.Parse(Console.ReadLine()!); // a = 4
int count = -a; // count = -4
Console.WriteLine(count); 
while (count != a){
    if (a>0)
count++;// count = count + 1
else
count--;
Console.WriteLine(count);
}