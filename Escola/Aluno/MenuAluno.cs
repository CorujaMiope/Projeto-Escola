using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Escola
{
    public class MenuAluno:Program
    {
        public void Menu()
        {
            ADMaluno Aluno = new ADMaluno();

            Console.Clear();

            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine(" *               ADMINISTRAR ALUNO:                      *");
            Console.WriteLine(" *               1--CRIAR ALUNO                          *");
            Console.WriteLine(" *               2--EXCLUIR ALUNO                        *");
            Console.WriteLine(" *               3--ATRIBUIR NOTA                        *");
            Console.WriteLine(" *               4--VER NOTAS                            *");
            Console.WriteLine(" *               5--VOLTAR AO MENU                       *");
            Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.ResetColor();


            int verificar;

            bool tecla;

            tecla = int.TryParse(Console.ReadKey().KeyChar.ToString(), out verificar);

            if (tecla)
            {
                if (verificar == 1)
                {
                    Aluno.CriarAluno();

                }


                else if (verificar == 2)
                {
                    Aluno.ExcluirAluno();


                }

                else if (verificar == 3)
                {
                    Aluno.AtribuirNota();
                }

                else if(verificar == 4)
                {
                    Aluno.VerNota();
                }

                else if(verificar == 5)
                {
                    Console.Clear();

                    Sistema();

                }

                

            }


            if (!tecla || verificar <= 0 || verificar >= 6)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("VALOR INVÁLIDO\n");
                Console.ResetColor();
               

                Menu();
            }


        }

       
    }
}


