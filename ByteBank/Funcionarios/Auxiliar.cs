using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        private const double _salario = 2000;
        private const double _taxaBonificacao = 0.20;
        private const double _aumentarSalario = 1.10;
        public Auxiliar(string cpf) : base(cpf, _salario, _taxaBonificacao, _aumentarSalario)
        {

        }

        //public override void AumentarSalario()
        //{
        //   Salario = Salario + (Salario * 0.1);
        //   Salario = Salario * 1.1;
        //   Salario *= 1.10;
        //}
    }
}
