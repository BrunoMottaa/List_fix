using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Fix
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }  

        public double Salario { get; private set;}


        public Funcionario(int id, string nome, double salario) //construtor formado com 3 parametros.
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }
        public void IncrementoSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
            
        }
        
        
    }
}
