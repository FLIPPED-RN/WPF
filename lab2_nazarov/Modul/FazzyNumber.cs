namespace lab2_nazarov.Modul;

public class FazzyNumber : IPair
{
    private double x;
    private double e1;
    private double er;

    public double X
    {
        get { return X; }
        set { value = x; }
    }

    public double ER
    {
        get { return er; }
        set { value = er; }
    }
    public FazzyNumber(double x, double e1, double e2)
    {
        this.x = x;
        this.e1 = e1;
        this.er = e2;
    }
    
    //вычитание
    public static FazzyNumber operator -(FazzyNumber A, FazzyNumber B)
    {
        double x = A.x - B.x;
        double e1 = A.x - B.x - A.e1 - B.e1;
        double er = A.x - B.x + A.er + B.er;
        return new FazzyNumber(x, e1, er);
    }

    //сложение
    public static FazzyNumber operator +(FazzyNumber A, FazzyNumber B)
    {
        double x = A.x + B.x;
        double e1 = A.x + B.x - A.e1 - B.e1;
        double er = A.x + B.x + A.er + B.er;
        return new FazzyNumber(x, e1, er);
    }

    //умножение
    public static FazzyNumber operator *(FazzyNumber A, FazzyNumber B)
    {
        double x = A.x * B.x;
        double e1 = A.x * B.x - B.x * A.e1 - A.x * B.e1 + A.e1 * B.e1;
        double er = A.x * B.x + B.x * A.er + A.x * B.er + A.er * B.er;
        return new FazzyNumber(x, e1, er);
    }
    
    //деление
    public static FazzyNumber operator /(FazzyNumber A, FazzyNumber B)
    {
        if (B.x <= 0)
            throw new ArgumentOutOfRangeException();
        double x = A.x / B.x;
        double e1 = (A.x - A.e1) / (B.x + B.er);
        double er = (A.x + A.er) / (B.x - B.e1);
        return new FazzyNumber(x, e1, er);
    }

    //обратное число
    public static FazzyNumber operator !(FazzyNumber A)
    {
        int NumberOne = 1;
        if (A.x <= 0)
            throw new ArgumentOutOfRangeException();
        double x = NumberOne / A.x;
        double e1 = (NumberOne / (A.x + A.er));
        double er = NumberOne / (A.x - A.e1);
        return new FazzyNumber(x, e1, er);
    }

    public override string ToString()
    {
        return string.Format($"{x}, {e1}, {er}");
    }
}