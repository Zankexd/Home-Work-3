void Palindrom(int a1)
{
int[] Masiv= {0,0,0,0,0};

//Masiv[0]= a/10000;
//a=(Masiv[0]*10000 -a)*-1;
//Console.Write(Masiv[0]);
//Masiv[1]= a/1000;
//a=(Masiv[1]*1000-a)*-1;
//Console.Write(Masiv[1]);
//Masiv[2]=a/100;
//a=(Masiv[2]*100-a)*-1;
//Masiv[3]=a/10;
//a=(Masiv[3]*10-a)*-1;
//Masiv[4]=a/1;
//a=(Masiv[4]*1-a)*-1;
//Console.WriteLine(Masiv[0]);
//Console.WriteLine((Masiv[1]));
//Console.WriteLine(Masiv[2]);
//Console.WriteLine((Masiv[3]));
//Console.WriteLine(Masiv[4]);

int index =0;
int b=10000;
while(index<5)
{
    Masiv[index]=a1/b;
    a1=(Masiv[index]*b-a1)*-1;
    b=b/10;
    Console.WriteLine(Masiv[index]);
index=index+1;
}
if (Masiv[0]==Masiv[4])
{
    if(Masiv[1]==Masiv[3])
    {
        Console.Write("Это палиндром");
    }
else
{
    Console.Write("Это  не палиндром");
}

}
else
{
    Console.Write("Это  не палиндром");
}
}

    Palindrom(new Random().Next(10000,100000));

