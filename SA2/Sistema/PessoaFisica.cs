using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public DateTime dataNascimento { get; set; }

        public override float PagarImposto(float salario){
            if(salario <= 1500){
                return 0;
            }else if(salario > 1500 && salario <= 5000){
                return salario * 3 / 100;
            }else if(salario > 5000){
                return salario * 5 / 100;
            }else{
                return 0;
            }
        }

        public bool ValidarDataNascimento(DateTime dataNascimento){
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNascimento).TotalDays / 365;

            if(anos >= 18){
                return true;
            }else{
                return false;
            } 
        }
    }
}