using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Aluno
    {
        static Aluno()
        {
            List<string> ListaProfessores = new List<string>();

            Console.WriteLine("1--CADASTRAR ALUNO(A)\n2--EDITAR ALUNO(A)\n3--NOTAS DO(A) ALUNO(A)");


            int verificar;

            bool tecla;

            tecla = int.TryParse(Console.ReadKey().KeyChar.ToString(), out verificar);


            if (verificar == 1)
            {
                Console.WriteLine("CADASTRAR ALUNO(A)");


            }


            else if (verificar == 2)
            {
                Console.WriteLine("EDITAR ALUNO(A)");
            }

            else if (verificar == 3)
            {
                Console.WriteLine("NOTAS DO(A) ALUNO(A)");
            }

            Console.ReadLine();
        }
    }
}
