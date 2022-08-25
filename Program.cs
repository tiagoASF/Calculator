
Console.Clear();
EntradaNoSistema();
Menu();


static void EntradaNoSistema()
{
    Console.WriteLine("********************************************");
    Console.WriteLine("**** Seja bem-vindo a nossa calculadora ****");
    Console.WriteLine("********************************************");
    Console.WriteLine("");
    
}

static void SaidaDoSistema()
{
    Console.WriteLine("Obrigado por usar nossa calculadora!");
    Console.WriteLine("Em breve com novas operações e correções");
    System.Environment.Exit(0);
}


static void Menu()
{
    Console.WriteLine("Operações disponíveis");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("-------------------------------");
    Console.Write("Selecione uma opção: ");
    short opcaoDesejada = short.Parse(Console.ReadLine());
    Console.WriteLine("");

    switch (opcaoDesejada)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5: SaidaDoSistema(); break;
        default: Menu(); break; 
    }
}


    
static void Soma()
{
    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da soma de {v1} e {v2} é {v1 + v2}.");
}

static void Subtracao()
{
    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da subtração de {v1} por {v2} é {v1 - v2}.");
}

static void Multiplicacao()
{
    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado da multiplicação entre {v1} e {v2} é {v1 * v2}.");
}

static void Divisao()
{
    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());
    
    if (v2 <= 0)
    {
        Console.WriteLine("A divisão por zero ou números negativos não é possível");
    }
    else
    {
        Console.WriteLine($"O resultado da divisão de {v1} por {v2} é {v1 / v2}.");
    }
}