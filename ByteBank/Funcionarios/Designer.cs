using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        private const double _salario = 3000;
        private const double _taxaBonificacao = 0.17;
        private const double _aumentarSalario = 1.11;
        public Designer(string cpf) : base(cpf, _salario, _taxaBonificacao, _aumentarSalario)
        {

        }

        // public override double _taxaBonificacao => 0.17;
    }
}
