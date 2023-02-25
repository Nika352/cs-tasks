
Console.WriteLine("enter int below this text");
int enteredInt = int.Parse(Console.ReadLine());
Boolean isEven = false;
if (enteredInt % 2 == 0)
{
    isEven = true;
}

if (isEven)
{
    Console.WriteLine("entered integer is even");
}
else
{
    Console.WriteLine("entered integer is odd");
}