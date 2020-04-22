using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_conjuntos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");

            for ( int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                A.Add(a);
            }

            Console.Write("O curso B possui quantos alunos? ");
             n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");

            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                B.Add(b);
            }

            Console.Write("O curso C possui quantos alunos? ");
             n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");

            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(Console.ReadLine());
                C.Add(c);
            }

            HashSet<int> novo = new HashSet<int>();
            novo.UnionWith(A);
            novo.UnionWith(B);
            novo.UnionWith(C);

            Console.WriteLine("Total de alunos: "+novo.Count);


        }
    }
}
