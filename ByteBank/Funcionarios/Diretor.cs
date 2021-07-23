using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        private const double _salario = 5000;
        private const double _taxaBonificacao = 0.50;
        private const double _aumentarSalario = 1.50;
        public Diretor(string cpf) : base(cpf, _salario, _taxaBonificacao, _aumentarSalario)
        {
            Console.WriteLine("Criando DIRETOR");
        }
    }
}
