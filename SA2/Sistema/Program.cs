namespace Sistema{
public class program{
static void Main(string[] args)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(@$"
    ===============================================
    !                                             !
    !        Seja Bem Vindo ao nosso Sistema      !
    !        de Cadastro de Pessoa Física e       !
    !        Juridica                             !
    !                                             !
    ===============================================
    ");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("iniciando ");
    Thread.Sleep(500);
    Console.Write("#");

    for(var contador = 0; contador < 10; contador++){
        Console.Write("#");
        Thread.Sleep(500);
    }
    Console.ResetColor();

    string opcao;
    do{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(@$"
    ===============================================
    !        Escolha uma das opções abaixo        !
    ===============================================
    !                                             !
    !           1 - Pessoa Física                 !
    !           2 - Pessoa Jurídica               !
    !                                             !
    !           0 - Sair                          !
    !                                             !
    ===============================================
    ");
    opcao = Console.ReadLine();

    switch(opcao){
        case "1":
        break;
        case "2":
        break;
        case "0":
        break;
        default:
        Console.WriteLine("Opção inválida, por favor digite uma das opções apresentadas");
        break;
    }
    }while(opcao != "0");

    Console.ResetColor();
}
}
}