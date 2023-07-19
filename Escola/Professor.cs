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
        private static string nome { get; set; }
        private static string materia { get; set; }

        public List<string> ListaProfessores = new List<string>();


        public void Menu()
        {

            Console.WriteLine("1--CADASTRAR PROFESSOR\n2--EDITAR PROFESSOR\nATRIBUIR NOTA A UM ALUNO(A)");

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

            


        //FUNÇÃO QUE CRIA PROFESSOR
        private void ProfessoresCadastro()
        {
            

            Console.Clear();

            Console.WriteLine("CADASTRAR PROFESSOR");

            Console.Write("Nome do professor: ");
            nome = Console.ReadLine();

            Console.Write("\nMatéria do professor: ");
            materia = Console.ReadLine();

            while (materia == "" || nome == "")
            {
                Console.WriteLine("ERRO, TENTE NOVAMENTE\n");

                ProfessoresCadastro();
            }

            string prof = $"\nProfessor: {nome} | Materia: {materia}\n";

            ListaProfessores.Insert(0,prof);
               
            Console.Clear() ;

            Console.WriteLine("Lista de Professores:\n");

            foreach (string s in ListaProfessores)
            {

                Console.WriteLine(s.ToString());

               
            }
           

            Console.ReadKey();

            Console.Clear();

            Menu();

           
        }

            
            //FUNÇÃO QUE EDITA PROFESSOR
            private void EditarProfessor()
            { 
                    Console.Clear();

                    

                    Console.WriteLine("EDITAR PROFESSOR\n O QUE DESEJA FAZER?:\n 1--MUDAR INFORMAÇÕES DE PROFESSOR | 2--EXCLUIR PROFESSOR\n");

                int verificar;

                bool tecla;

                tecla = int.TryParse(Console.ReadKey().KeyChar.ToString(), out verificar);

                Console.Clear();

                if (verificar == 1 )
                {
                    Console.WriteLine("MUDAR INFORMAÇÕES DE PROFESSOR\n 1--MUDAR NOME | 2--MUDAR MATÉRIA:");

                    var entrada = Console.ReadLine();
                    int saida;

                    bool opc = int.TryParse(entrada, out saida);


                    
                       
                    //MUDAR INFO DO PROFESSOR
                    switch (saida)
                    {
                       case 1:

                        //MECHENDO NA LISTA
                        foreach (string s in ListaProfessores)
                        {
                            
                            
                            int indice = ListaProfessores.)

                            Console.WriteLine("Mudara o nome de qual professor?");
                           


                        }

                        break;
                      
                    }
                 
                }

                else if (verificar == 2)
                {
                    Console.WriteLine("EXCLUIR PROFESSOR");
                }

                else
                {
                Console.WriteLine("Valor inválido, tente novamente\n");

                 EditarProfessor();

                }
   

            }
            
               
            
            //FUNÇÃO QUE ATRIBUI NOTA AO ALUNO
            protected void NotaAluno()
            {
                Console.Clear();

                Console.WriteLine("ATRIBUIR NOTA A UM ALUNO(A)");
            }

           

           
        }

       
        

        
        
        


    
}
