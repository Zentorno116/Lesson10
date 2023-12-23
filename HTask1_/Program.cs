
class Program
{
    static void Main()
    {
        Complex c1 = new Complex(1, 2);
        Complex c2 = new Complex(3, 4);

        Complex sum = c1 + c2;
        Complex diff = c1 - c2;
        Complex prod = c1 * c2;

        Console.WriteLine($"c1 = {c1}");
        Console.WriteLine($"c2 = {c2}");
        Console.WriteLine($"c1 + c2 = {sum}");
        Console.WriteLine($"c1 - c2 = {diff}");
        Console.WriteLine($"c1 * c2 = {prod}");
        Console.WriteLine($"c1 == c2? {c1 == c2}");
    }
}
