namespace Sistema
{
    public class program
    {
        static void Main(string[] args)
        {
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            List<PessoaFisica> listaPf = new List<PessoaFisica>();

            static void BarraCarregamento(string texto)
            {
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
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(@$"
==================================================================
|                   Escolha uma das opções abaixo                |
==================================================================
|                     Pessoa Física                              |
|                 1 - Cadastrar Pessoa Fisica                    |
|                 2 - Listar Pessoa Fisica                       |
|                 3 - Remover Pessoa Fisica                      |
|                                                                |
|                     Pessoa Juridica                            |
|                 4 - Cadastrar Pessoa Juridica                  |
|                 5 - Listar Pessoa Juridica                     |
|                 6 - Remover Pessoa Juridica                    |
|                                                                |
|                 0 - Sair                                       |    
==================================================================");
                Console.ResetColor();
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    
                    /*
                        Endereco endPf = new Endereco();
                        Console.WriteLine("Digite seu logradouro");
                        endPf.logradouro = Console.ReadLine();

                        Console.WriteLine("Digite o número da residencia");
                        endPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine(@$"Digite um complemento ou precione ENTER para pular");
                        endPf.complemento = Console.ReadLine();

                        Console.WriteLine("Este endereço é comercial? (S = SIM / N = NÃO");
                        string endComercial = Console.ReadLine().ToUpper();

                        if (endComercial == "S")
                        {
                            endPf.enderecoComercial = true;
                        }
                        else
                        {
                            endPf.enderecoComercial = false;
                        }

                        PessoaFisica pf = new PessoaFisica();
                        pf.endereco = endPf;
                        */
                        PessoaFisica novaPf = new PessoaFisica();

                        Console.WriteLine($"Digite seu CPF (somente números)");
                        novaPf.CPF = Console.ReadLine();

                        Console.WriteLine($"Digite seu nome");
                        novaPf.nome = Console.ReadLine();

                        Console.WriteLine($"Digite o valor do seu rendimento mensal");
                        novaPf.salario = float.Parse(Console.ReadLine());

                        /*
                        Console.WriteLine("Digite o valor do seu salário");
                        pf.salario = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a data do seu aniversário [AA/MM/DD]");
                        pf.dataNascimento = DateTime.Parse(Console.ReadLine());
                        */
                        bool idadeValida = novaPf.ValidarDataNascimento(novaPf.dataNascimento);
                        if (idadeValida == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("*                Seu Cadastro Foi Aprovado                            *");
                            listaPf.Add(novaPf);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("* Seu Cadastro Foi Reprovado Por Motivos de Idade Minima Não Atingida *");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }


                        // StreamWriter sw = new StreamWriter($"{pf.nome}.txt");
                        // sw.Write($"{pf.nome}");
                        // sw.Close();

                        using(StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt")){
                        sw.Write($"{novaPf.nome}");
                        sw.WriteLine(novaPf.CPF);
                        sw.WriteLine(novaPf.salario);
                       }

                        break;

                    case "2":
                    //Listar pessoa física
                        //foreach(var cadaItem in listaPf){
                        //    Console.WriteLine($"{cadaItem.nome}, {cadaItem.CPF}");
                       // }

                       Console.WriteLine("Digite o nome da pessoa que quer ler o cadastro");
                       string pessoa = Console.ReadLine();

                        using(StreamReader sr = new StreamReader($"{pessoa}.txt")){
                            string linha;
                            while((linha = sr.ReadLine()) != null){
                                Console.WriteLine($"{linha}");
                            }        
                        }
                        Console.WriteLine($"Aperte 'Enter' para continuar...");
                        Console.ReadLine();

                        break;

                    case "3":
                    //Remover pessoa física
                        Console.WriteLine("Digite o CPF do querido que deseja remover [somente números]");
                        string cpfProcurado = Console.ReadLine();
                        PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.CPF == cpfProcurado);

                        if(pessoaEncontrada != null){
                            listaPf.Remove(pessoaEncontrada);
                            Console.WriteLine("Pessoa removida");
                        }else{
                            Console.WriteLine("CPF não encontrado");
                        }

                        break;

                    case "4":
                    //Cadastrar pessoa juridica
                        novaPj.nome = "Nome PJ";
                        novaPj.CNPJ = "00.000.000/0001-00";
                        novaPj.razaoSocial = "Razão Social PJ";

                        novoEndPj. logradouro = "Alameda Barão de Limeira";
                        novoEndPj.numero = 539;
                        novoEndPj.complemento = "SENAI informática";
                        novoEndPj.enderecoComercial = true;

                        novaPj.endereco = novoEndPj;

                        novaPj.Inserir(novaPj);

                        break;

                    case "5":
                    //Listar pessoa juridica
                        List<PessoaJuridica> listaPj = novaPj.Ler();
                        foreach(PessoaJuridica cadaItem in listaPj){
                            Console.Clear();
                            Console.WriteLine(@$"
                            Nome: {cadaItem.nome}
                            Razão Social: {cadaItem.razaoSocial}
                            CNPJ: {cadaItem.CNPJ}");
                        }

                        break;

                    case "6":
                    //Remover pessoa jurídica

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