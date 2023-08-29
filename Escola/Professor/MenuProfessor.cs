<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Escola
{
    internal class MenuProfessor:Program
    {
        public void Menu()
        {
            ADMprofessor professor = new ADMprofessor();
            
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine(" *               ADMINISTRAR PROFESSOR:                  *");
            Console.WriteLine(" *               1--CADASTRAR PROFESSOR                  *");
            Console.WriteLine(" *               2--EXCLUIR PROFESSOR                    *");
            Console.WriteLine(" *               3--RETORNAR AO MENU                     *");          
            Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.ResetColor();
            int verificar;

            bool tecla;

            tecla = int.TryParse(Console.ReadKey().KeyChar.ToString(), out verificar);

            
            if (tecla )
            {
                if (verificar == 1)
                {
                    professor.ProfessoresCadastro();
                }

                //Editar professor
                else if (verificar == 2)
                {
                    professor.Editor();
                }

                
                else if (verificar == 3)
                {
                    Console.Clear();

                    Sistema();


                }

            }

            try
            {
                if (!tecla || verificar > 3 || verificar < 1)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("VALOR INVÁLIDO\n");
                    Console.ResetColor();

                    Console.ReadLine();

                    Menu();
                }
            } catch (Exception ) { Menu(); }


        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Escola
{
    internal class MenuProfessor:Program
    {
        public void Menu()
        {
            ADMprofessor professor = new ADMprofessor();
            
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine(" *               ADMINISTRAR PROFESSOR:                  *");
            Console.WriteLine(" *               1--CADASTRAR PROFESSOR                  *");
            Console.WriteLine(" *               2--EXCLUIR PROFESSOR                    *");
            Console.WriteLine(" *               3--RETORNAR AO MENU                     *");          
            Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.ResetColor();
            int verificar;

            bool tecla;

            tecla = int.TryParse(Console.ReadKey().KeyChar.ToString(), out verificar);

            
            if (tecla )
            {
                if (verificar == 1)
                {
                    professor.ProfessoresCadastro();
                }

                //Editar professor
                else if (verificar == 2)
                {
                    professor.Editor();
                }

                
                else if (verificar == 3)
                {
                    Console.Clear();

                    Sistema();


                }

            }

            while (!tecla && verificar >= 3 || verificar <1)
            {
                Console.Clear() ;

                Console.WriteLine("VALOR INVÁLIDO\n");
                
                Thread.Sleep(1000);

                Console.Clear();
                Menu();
            }
           


        }
    }
}
>>>>>>> c9f32b686204af0dd99e23fa665e61fdead93f08
