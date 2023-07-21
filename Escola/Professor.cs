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
        string nome;
        string materia;
        string SerieSala;
        double notas;
       

        //LISTA QUE GUARDARA O PROFESSOR
        public static List<Professor> ListaProfessor = new List<Professor>();

        //LISTA DE SALAS
        public static List<String> ListaDeSalas = new List<String>();

        //CONSTRUTOR
        public Professor(string Nome, string Materia, string Sala)
        {


        }
        
        //MENU
        public void Menu()
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
            else if (verificar == 3)
            {
                NotaAluno();
            }


        }
        
        //TABELA DE MATERIAS
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

            //Nome do professor
            Console.Write("\nQUAL É O NOME DO PEOFESSOR?: ");
            nome = Console.ReadLine();

//---------------------------------------

            Console.Clear();

            //Equi vai ser aonde escolheremos a materia
            Console.Write("EM QUE MATÉRIA O MESMO LECIONARA?:\n ");

            //TABELA
            Console.WriteLine("1--PORTUGUÊS\n2--SOCIOLOGIA\n3--FILOSOFIA\n4--ARTES\n5--HISTÓRIA\n6--MATEMÁTICA".ToUpper());
            Console.WriteLine("7--QUIMICA\n8--BIOLOGIA\n9--FÍSICA\n10--ED.FÍSICA\n11--GEOGRAFIA\n12--INGLÊS".ToUpper());

            //AREA DE DIGITAÇÃO
            Console.Write("DIGITE: ");
            string escolha = Console.ReadLine();
            int converterPraNumero;

            //TRATAMENTO DE ERRO
            bool escolherMateria = int.TryParse(escolha, out converterPraNumero);

            

            //CONDIÇÃO SE A PESSOA DIGITAR UMA LETRA NO LUGAR DE NÚMERO

            while (escolherMateria == false )
            {
                
                Console.Clear() ;

                Console.WriteLine("VALOR INVALIDO\n");

                //REAPRESENTAÇÃO DA TABELA
                Console.WriteLine("1--PORTUGUÊS\n2--SOCIOLOGIA\n3--FILOSOFIA\n4--ARTES\n5--HISTÓRIA\n6--MATEMÁTICA".ToUpper());
                Console.WriteLine("7--QUIMICA\n8--BIOLOGIA\n9--FÍSICA\n10--ED.FÍSICA\n11--GEOGRAFIA\n12--INGLÊS".ToUpper());

                //AREA DE DIGITAÇÃO
                Console.Write("DIGITE NOVAMENTE: ");
                string rescolha = Console.ReadLine();
                int saida;
                
                escolherMateria = int.TryParse(rescolha, out saida);

                //VALOR SENDO RETORNADO PARA A VARIAVEL ORIGINAL
                converterPraNumero = saida;
            }

            //FIM DA CONDIÇÃO


            //ESOLHER A MATERIA NA TABELA ENUM
            int adapt = converterPraNumero - 1;

            var materiaEscolhida = (TabelaMateria)adapt;
            materia = materiaEscolhida.ToString();

            //CONFIRMAÇÃO QUE A MATERIA FOI ESCOLHIDA
            Console.WriteLine($"A MATERIA ESCOLHIDA FOI: {materia}");
            Console.ReadLine();

            //---------------------------------------------------------------


            // NÚMERO DE SALAS EM QUE O PROFESSOR DARA AULA
            Console.Clear ();

            Console.Write("EM QUANTAS SALAS O PROFESSOR DA AULA?:");
            string NumerosDeSala = Console.ReadLine();
            int TantoDeSala;

            //TRATAMENTO DE ERRO
            bool quantidadeSalas = int.TryParse(NumerosDeSala, out TantoDeSala);

            //NÚMERO DE REPETIÇÕES
            int repete = TantoDeSala;

            //CONDIÇÃO SE A PESSOA DIGITAR NÚMERO NO LUGAR DE LETRA
            while ( quantidadeSalas == false )
            {
                Console.Clear();

                Console.WriteLine("VALOR INVÁLIDO\nEM QUANTAS SALAS O PROFESSOR DARA AULA?:");
                Console.Write("\nDIGITE: ");
                string novoNumero = Console.ReadLine();
                int novoTanto;
                quantidadeSalas = int.TryParse(novoNumero, out novoTanto);
                repete = novoTanto;
            }
            //FIM DE CONDIÇÃO

            //MENSSAGEM DE TESTE
            //Console.WriteLine($"repetira {repete} vezes");
            //Console.ReadLine(); DEU CERTO

//---------------------------------------------------------------
            
            //REPETIÇÃO: O menos 1 é porque na hora de repetir, sempre dava uma repetição a mais
            for( int i = 0; i <= (repete-1); i++)
            {
                //Console.WriteLine("\nRepetindo");
                
                Console.Write("EM QUAL SÉRIE O(A) PROFESSOR(A) DARA AULA?: ");
                string serie = Console.ReadLine();
                int numSerie;
                
                //TRATAMENTO DE ERRO
                bool tantoSerie = int.TryParse(serie, out numSerie);

                //CONDIÇÃO
                while ( tantoSerie == false )
                {
                    Console.Write("VALOR INVÁLIDO\n EM QUAL SÉRIE O(A) PROFESSOR(A) DARA AULA?: ");
                    string novaSerie = Console.ReadLine();
                    int NovoNumSerie;

                    //NOVO TRATAMENTO DE ERRO
                    tantoSerie = int.TryParse(novaSerie, out NovoNumSerie);

                }
                


            }


            Console.ReadKey();

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

            if (verificar == 1)
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


