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
        public Designer(string cpf) : base(cpf, _salario, _taxaBonificacao)
        {

        }

        // public override double _taxaBonificacao => 0.17;

        public override void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario * 1.1;
            Salario *= 1.11;
        }
    }
}
