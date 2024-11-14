Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

int number;

Console.Write("Введіть число від 0 до 9: ");
if (int.TryParse(Console.ReadLine(), out number))
{
    switch (number)
    {
        case 0:
            Console.WriteLine("нуль");
            break;
        case 1:
            Console.WriteLine("один");
            break;
        case 2:
            Console.WriteLine("два");
            break;
        case 3:
            Console.WriteLine("три");
            break;
        case 4:
            Console.WriteLine("чотири");
            break;
        case 5:
            Console.WriteLine("п'ять");
            break;
        case 6:
            Console.WriteLine("шість");
            break;
        case 7:
            Console.WriteLine("сім");
            break;
        case 8:
            Console.WriteLine("вісім");
            break;
        case 9:
            Console.WriteLine("дев'ять");
            break;
        default:
            Console.WriteLine("Число не входить у діапазон від 0 до 9.");
            break;
    }
}
else
{
    Console.WriteLine("Некоректне значення. Введіть ціле число.");
}
