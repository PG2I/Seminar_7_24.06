int Max(int num)
{
  if (num/10 > num % 10)

  return num/10;

  else 

  return num % 10;
    
}
int RNum = new Random().Next (10,100);
Console.WriteLine("" + RNum);
int result = Max(RNum);
Console.WriteLine("" + result);