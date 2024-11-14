using static System.Math;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
int readline()
{
    int value;
    bool isCorrect = false;
    do
    {
        isCorrect = int.TryParse(Console.ReadLine(), out value);
        if (!isCorrect)
        {
            Console.WriteLine("Значення було веддено не коректно, введіть ще раз....");
        }
    } while (!isCorrect);
    return value;
}
Console.WriteLine($"\nf(x)=..x^2 + b*x + c");
int a = readline();
Console.Clear();
Console.WriteLine($"\nf(x)={a}*x^2 + ..x + c");
int b = readline();
Console.Clear();
Console.WriteLine($"\nf(x)={a}*x^2 + ({b}*x) + ..c");
int c = readline();
Console.Clear();
Console.WriteLine($"\nf(x)={a}*x^2 + ({b}*x) + {c}");
int D = b * b - 4 * a * c;
Console.WriteLine($"D = {D}");
if (D < 0)
{
    Console.WriteLine("Коренів не існує);");
}
else if (D == 0)
{
    double x = b / (2.0 * a);
    Console.WriteLine($"Один корінь рівняння: х = {x}");
}
else
{
    double x1 = Round((-b - Sqrt(D)) / (2.0 * a), 2);
    double x2 = Round((-b + Sqrt(D)) / (2.0 * a), 2);
    Console.WriteLine($"Два кореня рівняння: х1 = {x1} х2 = {x2} ");
}

