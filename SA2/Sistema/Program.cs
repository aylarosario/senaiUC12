namespace Sistema{
public class program{
static void Main(string[] args)
{
/*
    Endereco end = new Endereco();
    end.logradouro = "Rua x";
    end.numero = 100; 
    end.complemento = "Qualquer coisa";
    end.enderecoComercial = false;

    PessoaFisica pf = new PessoaFisica();
    pf.endereco = end;
    pf.nome = "Ayla Rosario";
    pf.CPF = "0335978600";
    pf.dataNascimento = new DateTime(1998, 09, 24);


    bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);
    Console.WriteLine(idadeValida);

    if(idadeValida == true){
        System.Console.WriteLine("Cadastro Aprovado");
    }else{
        Console.WriteLine("Cadastro Reprovado");
    }
    */


    PessoaJuridica pj = new PessoaJuridica();
    Endereco end = new Endereco();
    end.logradouro = "Rua x";
    end.numero = 100; 
    end.complemento = "Qualquer coisa";
    end.enderecoComercial = true;

    pj.endereco = end;
    pj.CNPJ = "12345678990001";
    pj.razaoSocial = "Pessoa Juridica";

    if(pj.validarCNPJ(pj.cnpj)){
        Console.WriteLine("cnpj valido");
    }else{
        Console.WriteLine("cnpj invalido");
    }
}
}
}