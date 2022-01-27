using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Entidades.Enuns;

namespace Work.Entidades
{
    internal class Trabalhador
    {
        public string nome { get; set; }
        public LevelTrabalho level { get; set; }
        public double salarioBase { get; set; }
        public Departamento departamento { get; set; }
        public List<Contrato> horaContrato { get; set; } = new List<Contrato>();
        //Instanciando a lista pra garantir que ela não seja nula

        public Trabalhador()
        {

        }

        public Trabalhador(string nome, LevelTrabalho level, double salarioBase, Departamento departamento)
        {
            this.nome = nome;
            this.level = level;
            this.salarioBase = salarioBase;
            this.departamento = departamento;
        }

        public void AddCOntrato(Contrato contrato)
        {
            horaContrato.Add(contrato);

        }

        public void removerContrato(Contrato contrato)
        {
            horaContrato.Remove(contrato);
        }

        public double ganhoMes(int ano, int mes)
        {
            double soma = salarioBase;
            foreach (Contrato contrato in horaContrato)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }

    }
}
