using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Escola
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sistema();
            
        }

        public static void Sistema()
        {
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine(" *               QUE PÁGINA DESEJA ACESSAR?:             *");
            Console.WriteLine(" *               1--ADMINISTRAR PROFESSOR                *");
            Console.WriteLine(" *               2--ADMINISTRAR ALUNO(A)                 *");           
            Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.ResetColor();
            int verificar;

            bool tecla;

            tecla = int.TryParse(Console.ReadKey().KeyChar.ToString(), out verificar);

            if (tecla)
            {

                if (verificar == 1)
                {
                    Console.Clear();

                    Console.WriteLine("CRIAR E EDITAR PROFESSOR\n");

                    MenuProfessor professor = new MenuProfessor();

                    professor.Menu();



                    Console.ReadLine();

                }


                else if (verificar == 2)
                {
                    Console.Clear();

                    Console.WriteLine("CRIAR E EDITAR ALUNO(A)\n");

                    MenuAluno menuAluno = new MenuAluno();
                    menuAluno.Menu();
                }

               

            }

            while(!tecla || verificar > 2 || verificar <= 0)
                {
                    Console.Clear();

                    Console.WriteLine("VALOR INVÁLIDO\n");

                    Sistema();

                }


          

        }

       
    }
}
