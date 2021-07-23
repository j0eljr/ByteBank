using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        private const double _salario = 4000;
        private const double _taxaBonificacao = 0.25;
        private const double _aumentarSalario = 1.05;
        public GerenteDeConta(string cpf) : base(cpf, _salario, _taxaBonificacao, _aumentarSalario)
        {
            
        }
    }
}
