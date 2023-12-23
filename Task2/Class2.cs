using System;
public class Rational
{
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }

    public Rational(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        Numerator = numerator;
        Denominator = denominator;
    }

    public static bool operator ==(Rational r1, Rational r2)
    {
        return r1.Numerator * r2.Denominator == r2.Numerator * r1.Denominator;
    }

    public static bool operator !=(Rational r1, Rational r2)
    {
        return !(r1 == r2);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Rational r = (Rational)obj;
        return this == r;
    }

    public override int GetHashCode()
    {
        return Numerator ^ Denominator;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }

    public static explicit operator float(Rational r)
    {
        return (float)r.Numerator / r.Denominator;
    }

    public static explicit operator int(Rational r)
    {
        return r.Numerator / r.Denominator;
    }

    public static explicit operator Rational(float f)
    {
        return new Rational((int)(f * 100), 100);
    }

    public static explicit operator Rational(int i)
    {
        return new Rational(i, 1);
    }

    // Определение операторов *, /, % здесь
}