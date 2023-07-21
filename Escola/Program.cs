using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUE PÁGINA DESEJA ACESSAR:\n1--PÁGINA DO PROFESSOR\n2--PÁGINA DO ALUNO(A)");


            int verificar;

            bool tecla;

            tecla = int.TryParse(Console.ReadKey().KeyChar.ToString(), out verificar);


            if (verificar == 1)
            {
                Console.Clear();

                Console.WriteLine("PÁGINA DO PROFESSOR\n");

                Professor professor = new Professor(" ", " ", " ");

                professor.Menu();

                

                Console.ReadLine(); 

            }


            else if (verificar == 2)
            {
                Console.Clear();

                Console.WriteLine("PÁGINA DO ALUNO(A)\n");

                Aluno estudante = new Aluno();

                estudante.Menu();
            }


            
        
        }
    }
}
