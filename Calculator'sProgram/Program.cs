
using System.Security.Cryptography.X509Certificates;

num1:
Console.WriteLine("Enter Your First Number");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Your Second Number");
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Your Operator like +,-,*,/");
string oprt=Console.ReadLine();
switch (oprt)
{
    case "+":
        int sum=num1 + num2;
        Console.WriteLine("Addition of your number is="+ sum);
        break;
    case "-":
        int sub=num1 - num2;
        Console.WriteLine("Substraction of your number is="+sub);
        break;
    case "*":
        int mult=num1 * num2;
        Console.WriteLine("Multiplication of your number is="+ mult);
        break;
    case "/":
        int div=num1 / num2;
        Console.WriteLine("Division of your number is="+ div);
        break;
    case "%":
        int rem=num1 % num2;
        Console.WriteLine("Remainder of your number is="+ rem);
        break;
   

}
goto num1;