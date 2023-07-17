int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInput("Введите число: ");
int variable = 1;
while (variable <= num)
{
    double resalt = Math.Pow(variable,3);
    variable++;
    Console.Write($"{resalt} ");
}