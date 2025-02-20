// Console.Write - escreve algo na tela
// Console.WriteLine - escreve algo e pula uma linha
// Console.Read - lê
// Console.ReadKey - retorna o valor da tecla pressionada
// Console.ReadLine - lê uma linha

Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Escolha uma operação matemática para começar:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("-----------------");
    Console.WriteLine("Digite o número da opção desejada:");
    short resposta = short.Parse(Console.ReadLine());

    switch (resposta)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0);

            default : Menu(); break;
    }
};

static void Soma() //Método
{
    Console.Clear();
    Console.WriteLine("Primeiro valor:"); //escreve a frase entre parenteses e aspas;
    decimal v1 = decimal.Parse(Console.ReadLine()); // vai converter a string digitada pelo usuário para decimal e depois ficará guardada na memória;

    Console.WriteLine("Segundo valor:");
    decimal v2 = decimal.Parse(Console.ReadLine());

    decimal resultado = v1 + v2; // vai pegar os dois valores digitados pelo usuário e realizar a operação matemática;
    Console.WriteLine(""); // vai pular uma linha 
  //Console.WriteLine("O resultado da soma é: " + resultado); //vai escrever a frase e cocatenar com o resultado da operação realizada acima.
    Console.WriteLine($"O resultado da soma é: {resultado}"); //interpolação
                                                              //Console.WriteLine($"O resultado da soma é: {v1 + v2}");
                                                              //Console.WriteLine("O resultado da soma é: " + (v1 + v2));
    Console.ReadKey();
    Menu();
} 

static void Subtracao()   
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    decimal v1 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    decimal v2 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("");

    decimal resultado = v1 - v2;
    Console.WriteLine($"O resultado da subtração é {resultado}");
   
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    decimal v1 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    decimal v2 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("");

    decimal resultado = v1 / v2;
    Console.WriteLine($"O resultado da divisão é: {resultado}");

    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    decimal v1 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    decimal v2 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("");

    decimal resultado = v1 * v2;
    Console.WriteLine($"O resultado da multiplicação é: {resultado}");

    Console.ReadKey();
    Menu();
}