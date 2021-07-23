using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("789123456-99");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("159789321-77");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonicacao gerenciadorBonificacao = new GerenciadorBonicacao();

            Designer pedro = new Designer("123456789-00");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("789123456-99");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("123654789-55");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("159789321-77");
            camila.Nome = "Camila";

            Desenvolvedor joel = new Desenvolvedor("987123654-77");
            joel.Nome = "Joel";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(joel);

            Console.WriteLine("Total de bonificação do mês " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
