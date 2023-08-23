using System;
using System.Globalization;
using System.Collections.Generic;
using Lista_Fix;
using System.Xml.Linq;


namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos funcionários serão cadastrados?");
            int N = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();
            
            
            for(int i =1; i <= N; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario)); 
                Console.WriteLine();

                Console.WriteLine("Informe o CPF do funcionário que terá aumento salarial: ");
                int procurarid = int.Parse(Console.ReadLine());

                Funcionario x = list.Find(x => x.ID == procurarid);
                if(x != null)
                {
                    Console.Write("Entre com a porcentagem");
                    double porc = double.Parse(Console.ReadLine());
                    x.IncrementoSalario(porc);
                }
                else
                {
                    Console.WriteLine("Este ID não existe");
                }

                Console.WriteLine();
                Console.WriteLine("Lista atualizada de funcionários");
                foreach(Funcionario obj in list)
                {
                    Console.WriteLine(obj);
                }

            }
        }
    }
}