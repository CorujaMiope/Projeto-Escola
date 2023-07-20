using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Professor
    {
        //Variaveis
        
        


        public  static List<Professor> ListaProfessor = new List<Professor>();


        public Professor(string Nome, int Idade, string Materia, string Sala)
        {
            

        }

        public  void Menu()
        {

            Console.WriteLine("1--CADASTRAR PROFESSOR\n2--EDITAR PROFESSOR\nATRIBUIR NOTA A UM ALUNO(A)".ToUpper());

            int verificar;

            bool tecla;

            tecla = int.TryParse(Console.ReadKey().KeyChar.ToString(), out verificar);


            //Criar professor
            if (verificar == 1)
            {
                ProfessoresCadastro();
            }

            //Editar professor
            else if (verificar == 2)
            {
                EditarProfessor();
            }

            //Atribuir nota ao aluno
            else if(verificar == 3)
            {
                NotaAluno();
            }


            }

        public enum TabelaMateria
        {
            PORTUGUÊS,
            SOCIOLOGIA,
            FILOSOFIA,
            ARTES,
            HISTÓRIA,
            MATEMATICA,
            QUIMICA,
            BIOLOGIA,
            FÍSICA,
            ED_FÍSICA,
            GEOGRAFIA,
            INGLÊS
        }
        

        //FUNÇÃO QUE CRIA PROFESSOR
        private void ProfessoresCadastro()
        {
          
            Console.Clear();

            Console.Write("\nDigite o nome do professor: ".ToUpper());
            string nome = Console.ReadLine();

            Console.Write("\nDigite a data de nascimento: ".ToUpper());
            //idade=

            Console.WriteLine("\nEm que materia ele(a) lecionara?:\n".ToUpper());
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1--PORTUGUÊS\n2--SOCIOLOGIA\n3--FILOSOFIA\n4--ARTES\n5--HISTÓRIA\n6--MATEMÁTICA".ToUpper());
            Console.WriteLine("7--QUIMICA\n8--BIOLOGIA\n9--FÍSICA\n10--ED.FÍSICA\n11--GEOGRAFIA\n12--INGLÊS".ToUpper());
            Console.ResetColor();
            string materia = Console.ReadLine();
            int escolheMateria;
            bool materias = int.TryParse(materia, out escolheMateria);
            var MateriaEcolhido = (TabelaMateria)escolheMateria;
            

            Console.WriteLine("\nEm quantas salas ele dara aula?".ToUpper());
            string numSalas = Console.ReadLine();
            int salas;
            bool verificaSalas = int.TryParse(numSalas, out salas);
            int salass = salas;
            int i;
            string salaSerie;

            while (verificaSalas == false)
            {
                Console.WriteLine("\nEm quantas salas ele dara aula?".ToUpper());
                numSalas = Console.ReadLine();
                salas = 0;
                verificaSalas = int.TryParse(numSalas, out salas);
                salaSerie = "";
            }


            for ( i = 0; i <= salass; i++)
                {
                    Console.Write("\nEM QUE SÉRIE ELE DARA AULA? ".ToUpper());
                    string Numserie = Console.ReadLine();
                    int serie;
                    bool verificaSerie = int.TryParse(Numserie, out serie);

                    if (verificaSerie)
                    {
                        Console.Write("\nE QUAL SERA A SALA? Ex: A,B,C,D: ".ToUpper());
                        var letra = Console.ReadLine();

                        salaSerie = serie.ToString() + letra;
                    }

                    while (!verificaSerie)
                    {
                        Console.Write("\nEM QUE SÉRI ELE DARA AULA? ".ToUpper());
                        Numserie = Console.ReadLine();
                        serie = 0;
                        verificaSerie = int.TryParse(Numserie, out serie);

                        if (verificaSerie)
                        {
                            Console.Write("\nE QUAL SERA A SALA?? Ex: A,B,C,D: ".ToUpper());
                            var letra = Console.ReadLine();

                            salaSerie = serie.ToString() + letra;
                        }


                    }

               
                }
                  
            //Professor professor1 = new Professor(nome,);

            //ListaProfessor.Add(professor1);


            Menu();



        }

            
            //FUNÇÃO QUE EDITA PROFESSOR
            private void EditarProfessor()
            { 
                    Console.Clear();

                    

                    Console.WriteLine("EDITAR PROFESSOR\n O QUE DESEJA FAZER?:\n 1--MUDAR INFORMAÇÕES DE PROFESSOR | 2--EXCLUIR PROFESSOR\n".ToUpper());

                int verificar;

                bool tecla;

                tecla = int.TryParse(Console.ReadKey().KeyChar.ToString(), out verificar);

                Console.Clear();

                if (verificar == 1 )
                {
                    Console.WriteLine("MUDAR INFORMAÇÕES DE PROFESSOR\n 1--MUDAR NOME | 2--MUDAR MATÉRIA:".ToUpper());

                    var entrada = Console.ReadLine();
                    int saida;

                    bool opc = int.TryParse(entrada, out saida);


                 
                }

                else if (verificar == 2)
                {
                    Console.WriteLine("EXCLUIR PROFESSOR".ToUpper());
                }

                else
                {
                Console.WriteLine("Valor inválido, tente novamente\n".ToUpper());

                 EditarProfessor();

                }
   

            }
            
               
            
            //FUNÇÃO QUE ATRIBUI NOTA AO ALUNO
            protected void NotaAluno()
            {
                Console.Clear();

                Console.WriteLine("ATRIBUIR NOTA A UM ALUNO(A)".ToUpper());
            }

           

           
        }

       
        

        
        
        


    
}
