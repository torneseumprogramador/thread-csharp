using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramacaoParalela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione ENTER para iniciar");
            Console.ReadLine();

            // Invocar os métodos que vamos executar
            Parallel.Invoke(
               new Action(exibirDias),
               new Action(exibirMeses),
               new Action(exibirCidades)
            );

            // Aguardar a continuação do programa
            Console.WriteLine("\nO método Main foi encerrado. Tecle Enter");
            Console.ReadLine();
        }

        static void exibirDias()
        {
            string[] diasArray = { "Segunda", "Terça", "Quarta","Quinta", "Sexta", "Sábado", "Domingo" };
            foreach (string dia in diasArray)
            {
               Console.WriteLine("Dia da semana: {0}", dia);
               Thread.Sleep(500);
            }
        }
       
        static void exibirMeses()
        {
            string[] messArray = { "Jan", "Fev", "Mar", "Abr","Mai", "Jun", "Jul",
                                   "Ago", "Set", "Out", "Nov", "Dec" };

            foreach (string mes in messArray)
            {
               Console.WriteLine("Mês : {0}", mes);
                Thread.Sleep(500);
            }
        }
       
        static void exibirCidades()
        {
            string[] cidadesArray = { "Londres", "New York", "Paris", "Tóquio","Sidney" };
            foreach (string cidade in cidadesArray)
            {
               Console.WriteLine("Cidade : {0}", cidade);
                Thread.Sleep(500);
            }
        }
    }
}
