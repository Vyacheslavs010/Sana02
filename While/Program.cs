using static System.Math;
Console.OutputEncoding = System.Text.Encoding.UTF8;
int n;
n = int.Parse(Console.ReadLine());
double a=0,b=0,c=0;
while (n > 0) { 
    a+=Pow(-1,n)/(2*n+1);
    b += (double)(1 + 1 / (Pow(n, 2)));
    int temp = n,factorial=1;
    while (temp > 0) { 
    factorial *= temp;
        --temp;
    }
    c += factorial;
    --n;
}
Console.WriteLine($"Значення a: {a}");
Console.WriteLine($"Значення b: {b}");
Console.WriteLine($"Значення c: {c}");