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
        private readonly double _aumentarSalario;

        public Funcionario(string cpf, double salario, double taxaBonificacao, double aumentarSalario)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;
            _taxaBonificacao = taxaBonificacao;
            _aumentarSalario = aumentarSalario;
            
            TotalDeFuncionarios++;
        }

       
        public double AumentarSalario()
        {
            return Salario * _aumentarSalario;
        }

        public double GetBonificacao()
        {
            return Salario * _taxaBonificacao;
        }
    }
}
