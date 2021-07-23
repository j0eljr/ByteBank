using System;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; }
        public double Salario { get; protected set; }
        private readonly double _taxaBonificacao;
        
        public Funcionario(string cpf, double salario, double taxaBonificacao)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;
            _taxaBonificacao = taxaBonificacao;
            
            TotalDeFuncionarios++;
        }

       
        public abstract void AumentarSalario();

        public double GetBonificacao()
        {
            return Salario * _taxaBonificacao;
        }
    }
}
