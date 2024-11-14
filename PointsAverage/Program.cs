Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
const int requiredAverage = 50; 
const int numberOfGrades = 5;  
int sum = 0;
for (int i = 0; i < numberOfGrades; i++)
{
    int temp;
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out temp);
        if (!isCorrect)
        {
            Console.WriteLine("Значення було веддено не коректно, введіть ще раз....");
        }
        else if (temp > 100 || temp < 0)
        {
            Console.WriteLine("Значення було веддено не коректно, введіть ще раз....");
        }
        else {
            sum += temp;
            break;
        }
    }
}
double average = (double)sum / numberOfGrades;
Console.WriteLine($"\nСередній бал: {average:F2}");
if (average >= requiredAverage)
{
    Console.WriteLine("Студент допущений до екзамену.");
}
else
{
    Console.WriteLine("Студент не допущений до екзамену.");
}
