void Kub(double x , double y, double z ,double x1 ,double y1 ,double z1)
{
   
    double B = Math.Sqrt(Math.Pow(x1-x,2)+Math.Pow(y1-y,2)+Math.Pow(z1-z,2));
    Console.WriteLine(B);
}

Kub(3,1,3,2,6,8);
