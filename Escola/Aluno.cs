using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Aluno
    {
        private static string nome;
        private static  int RA;
         static private List<string> ListaDeAlunos = new List<string>();

        public void Menu()
        {
           

            Console.WriteLine("1--CADASTRAR ALUNO(A)\n2--EDITAR ALUNO(A)\n3--NOTAS DO(A) ALUNO(A)");


            int verificar;

            bool tecla;

            tecla = int.TryParse(Console.ReadKey().KeyChar.ToString(), out verificar);


            if (verificar == 1)
            {
                Console.Clear();

               

                CriarAluno();

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


        //CRIAÇÃO DE ALUNO
        static void CriarAluno()
        {
            Console.WriteLine("CADASTRAR ALUNO(A)");

            Console.WriteLine("\nQual é o nome do aluno(a): \n");
            nome = Console.ReadLine();

            var rand = new Random();
            RA = rand.Next(1, 100);

            string RAaluno = RA.ToString();



            string[] estudantes = { $"Estudante: {nome} RA: {RAaluno}" };

           
            ListaDeAlunos.AddRange(estudantes);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"ESTUDANTE CRIADO COM SUCESSO:\n");
            Console.ResetColor();

            foreach (string estudante in estudantes)
            {
                Console.WriteLine(estudante.ToString());
            }
        }

        static void EditarAluno()
        {
            Console.WriteLine("Qual aluno tera os dados editados?\n");
        }
    }
}
