using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Entidades;
using Work.Entidades.Enuns;

namespace Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do departamento");
            string nomeDepartamento = Console.ReadLine();

            //Console.WriteLine("Entrar com data do trabalho");

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Level do trabalhador (Junior/MidLevel/Senior)");
            LevelTrabalho level = new LevelTrabalho();
            Enum.TryParse(Console.ReadLine(), out level);

            Console.WriteLine("Salario base: ");
            double salarioBase = double.Parse(Console.ReadLine());

            
            Departamento dept = new Departamento(nomeDepartamento);
            Trabalhador trabalho = new Trabalhador(nome, level, salarioBase, dept);

            Console.WriteLine("Quantos contratos vão ser?");
            int qtdeContrato = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtdeContrato; i++)
            {
                Console.WriteLine("Entre com o contrato " + (i +1) + ": ");
                Console.WriteLine("Data (DD/MM/YYYY)");
                DateTime data = DateTime.Parse(Console.ReadLine());
                
                Console.WriteLine("Valor por hora");
                double valorPorHora = double.Parse(Console.ReadLine());
               
                Console.WriteLine("Quantidades de hora: ");
                int hora = int.Parse(Console.ReadLine());

                Contrato contrato = new Contrato(data, valorPorHora, hora);
                
                trabalho.AddCOntrato(contrato);
            }

            Console.WriteLine();
            Console.WriteLine("Entre com mes e ano (MM/YYYY): ");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3));

            Console.WriteLine("Nome: " + trabalho.nome);
            Console.WriteLine("Departamnto: " + trabalho.departamento.nome);
            Console.WriteLine("Pagamento: " + mesEano + ": " + trabalho.ganhoMes(ano, mes));


        }
    }
}
