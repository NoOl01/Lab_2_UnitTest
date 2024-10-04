namespace Lab2_Test;

public class LabTask
{
    public int Euclid (int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }
}