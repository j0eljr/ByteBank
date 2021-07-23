using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        private const double _salario = 3500;
        private const double _taxaBonificacao = 0.19;
        private const double _aumentarSalario = 1.21;
        public Desenvolvedor(string cpf) : base(cpf, _salario, _taxaBonificacao, _aumentarSalario)
        {

        }
    }
}
