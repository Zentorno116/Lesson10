class Program
{
    static void Main()
    {
        Rational r1 = new Rational(1, 2);
        Rational r2 = new Rational(2, 3);

        Console.WriteLine(r1 == r2); // Вывод: False
        Console.WriteLine(r1 != r2); // Вывод: True

        float f = (float)r1; // Преобразование Rational в float
        int i = (int)r1; // Преобразование Rational в int

        Rational r3 = (Rational)f; // Преобразование float в Rational
        Rational r4 = (Rational)i; // Преобразование int в Rational

        Console.WriteLine(r1); // Вывод: 1/2
        Console.WriteLine(r2); // Вывод: 2/3
        Console.WriteLine(r3); // Вывод: 50/100
        Console.WriteLine(r4); // Вывод: 0/1
    }
}