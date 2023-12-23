using System;

public class Complex
{
    public double Real { get; private set; }
    public double Imaginary { get; private set; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    public static Complex operator -(Complex c1, Complex c2)
    {
        return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }

    public static Complex operator *(Complex c1, Complex c2)
    {
        return new Complex(c1.Real * c2.Real - c1.Imaginary * c2.Imaginary, c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
    }

    public static bool operator ==(Complex c1, Complex c2)
    {
        return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
    }

    public static bool operator !=(Complex c1, Complex c2)
    {
        return !(c1 == c2);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Complex c = (Complex)obj;
        return this == c;
    }

    public override int GetHashCode()
    {
        return Real.GetHashCode() ^ Imaginary.GetHashCode();
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

