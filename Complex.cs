// var c1 = new Complex();
// var c2 = new Complex();

// var c3 = c1 + c2;

public class Complex
{
    public double Real {get;set;}
    public double Imaginary {get;set;}

    public static  implicit operator Complex((double r, double i) value)
    {
        return new Complex
        {
            Real = value.r,
            Imaginary = value.i,
        };
    }

    public static bool operator ==(Complex a, Complex b)
        => a.Real == b.Real && a.Imaginary == b.Imaginary;

    public static bool operator !=(Complex a, Complex b)
    {
        return !(a == b);
    }

    public static Complex operator +(Complex a, Complex b){
        return new Complex
        {
            Real = a.Real + b.Real,
            Imaginary = a.Imaginary + b.Imaginary
        };
    }
}