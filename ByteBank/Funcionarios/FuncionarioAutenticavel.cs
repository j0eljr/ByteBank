using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(string cpf, double salario, double taxaBonificacao, double aumentarSalario) : base (cpf, salario, taxaBonificacao, aumentarSalario )
        {
           
        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
