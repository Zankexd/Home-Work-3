void kubik (int a)
{
    int index= 0;
while(index<=a)
{
    Console.Write(","+Math.Pow(index,3));
    index++;
}
}
string a =Console.ReadLine();
int a1 =int.Parse(a);
kubik (a1);