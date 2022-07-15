using System.Threading;
using Threds;
var Thread1 = new Thread(Methods.Print1);
var Thread2 = new Thread(Methods.Print2);
var Thread3 = new Thread(Methods.Print3);
var Thread4 = new Thread(Methods.Print4);
Thread1.Start();
Thread2.Start();
Thread3.Start();
Thread4.Start();
int a;
for (int i = 0; i < 1000; i++)
{
    a=i*2;
    Console.WriteLine(a);
    Thread.Sleep(500);
}
