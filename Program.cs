int Dividendo, Divisor, Resto;

Console.WriteLine("Máximo Divisor Comum (método iterativo)\n");

Console.Write("Digite o Dividendo:");
Dividendo = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o divisor:");
Divisor = Convert.ToInt32(Console.ReadLine());

do
{   
    Resto = Dividendo % Divisor;
    Dividendo = Divisor;
    Divisor = Resto;
}
while(Resto !=0);

Console.WriteLine($"MDC(a, b) = {Dividendo}");