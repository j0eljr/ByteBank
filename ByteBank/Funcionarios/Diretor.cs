using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000, 0.5)
        {
            Console.WriteLine("Criando DIRETOR");
        }
        
        public override void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario * 1.1;
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
