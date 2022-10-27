namespace Sistema{
public class program{
static void Main(string[] args)
{
    static void BarraCarregamento(string texto){
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(texto);
                Thread.Sleep(500);
                Console.Write("#");

                for (var contador = 0; contador < 10; contador++)
                {
                    Console.Write("#");
                    Thread.Sleep(500);
                }
                Console.ResetColor();
            }


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

    BarraCarregamento("Iniciando ");

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
    Console.ResetColor();
    opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    Endereco endPf = new Endereco();
                    endPf.logradouro = "Rua Niteroi";
                    endPf.numero = 180;
                    endPf.complemento = "Escola SENAI Paulo Skaf";
                    endPf.enderecoComercial = false;

                    PessoaFisica Ayla = new PessoaFisica();
                    Ayla.CPF = "03359673278";
                    Ayla.dataNascimento = new DateTime(1998, 09, 24);
                    Ayla.endereco = endPf;
                    Ayla.nome = "Ayla Rayane dos Santos do Rosário";
                    float impostoapagar = Ayla.PagarImposto(5000);

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(@$"Imposto a pagar: {impostoapagar}
Nome: {Ayla.nome}
CPF: {Ayla.CPF}
Nascido em {Ayla.dataNascimento.ToString("dd/MM/yyyy")}
{endPf.logradouro}, {endPf.numero}");

                    Console.ResetColor();
                        break;

                    case "2":
                    Endereco endPj = new Endereco();
                    endPj.logradouro = "Rua Niteroi";
                    endPj.numero = 180;
                    endPj.complemento = "Escola SENAI Paulo Skaf";
                    endPj.enderecoComercial = true;

                    PessoaJuridica pj = new PessoaJuridica();
                    pj.CNPJ = "0141154798";
                    pj.endereco = endPj;
                    pj.razaoSocial = "Pessoa Juridica";
                    pj.nome = "Jequiti";
                    float impostopj = pj.PagarImposto(5000);

                    Console.WriteLine(impostopj);
                    Console.WriteLine(pj.CNPJ);

                        break;

                    case "0":
                        Console.WriteLine("Obrigado por utilizar nosso sistema");
                        BarraCarregamento("Finalizando ");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opção inválida, por favor digite uma das opções apresentadas");
                        Console.ResetColor();
                        break;
                }
            } while (opcao != "0");

    Console.ResetColor();
}
}
}