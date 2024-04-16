// See https://aka.ms/new-console-template for more information
const string SYSTEM_NAME  = "Calculadora matemática";
bool repeat = true;
string option;
Console.WriteLine($"Bem-Vindo ao sistema: {SYSTEM_NAME}");

while(repeat){
    Console.WriteLine("Forneça o primeiro número: ");
    string num1 = Console.ReadLine();
    while(num1 == ""){
    Console.WriteLine("Forneça o primeiro número: ");
     num1 = Console.ReadLine();
    }
    Console.WriteLine("Forneça o segundo número: ");
    string num2 = Console.ReadLine();
     while(num2 == ""){
    Console.WriteLine("Forneça o segundo número: ");
     num2 = Console.ReadLine();
    }
    OperacoesMatematicas opMat = new OperacoesMatematicas(int.Parse(num1),int.Parse(num2));
    Console.WriteLine("\n1-Soma\n2-Subtrair\n3-Multiplicar\n4-Dividir\n5-Sair");
    option = Console.ReadLine();
    while(option == ""){
        Console.WriteLine("Você deve escolher uma das opções válidas:");
        Console.WriteLine("\n1-Soma\n2-Subtrair\n3-Multiplicar\n4-Dividir\n5-Sair");
        option = Console.ReadLine();
    }
    switch (int.Parse(option))
    {
        case 1:
        Console.WriteLine($"\nResultado(Soma): {opMat.Somar()}");
        break;
        case 2:
        Console.WriteLine($"\nResultado(Subtração): {opMat.Subtrair()}");
        break;
        case 3:
        Console.WriteLine($"\nResultado(Multiplicação): {opMat.Multiplicar()}");
        break;
        case 4:
        Console.WriteLine($"\nResultado(Divisão): {opMat.Dividir()}");
        break;
        case 5:
        Console.WriteLine($"\nPrograma encerrado.");
        repeat = false;
        break;
    };
    Console.WriteLine("Pressione alguma tecla para prosseguir");
    Console.ReadKey();
    Console.Clear();
}