public class Math 
{

    double PI = 3.14;
    double E = 2.71;
    public double Abs(double value)
    {
        if (value < 0)return -value;
        else return value;
    }
   public float Abs(float value)
    {
         if (value < 0)return -value;
        else return value;
    }
    public int Abs(int value)
    {
        if (value < 0)return -value;
        else return value;
    }
   public double Pow(double x, double y)
    {
        double sum = 0;
        for(int i=0; i<=y; i++)
        {
            sum = x*x;
        }
        return sum;
    }
    public double Sqrt(int d)
    {
        double Z = 0;
        for (int i=2; i<d; i++)
        {
            if (d%i==0 && i*i==d)Z=i;
            break ;
        }
        return Z;
    }
    public int Max(int val1, int val2)
    {
        if (val1 > val2)return val1;
        else if (val1 < val2)return val2;
    }
    public int Min(int val1, int val2)
    {
         if (val1 < val2)return val1;
        else if (val1 > val2)return val2;
    }
}